using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SOAPTester
{
    public partial class eDHRTester : Form
    {
        public class DCP
        {
            public string tagNumber;
            public string result;
            public DCP(string tag, string val)
            {
                tagNumber = tag;
                result = val;
            }
        }

        public string CurrXML
        {
            get
            {
                return CreateFeaturesPassedMessage();
            }
        }

        public string ReturnedXML;
        public IDictionary<string, string> dict;

        public eDHRTester()
        {
            InitializeComponent();
            dict = new Dictionary<string, string>();
        }

        private void AddDcpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dict.Add(Tag.Text.ToString(), Value.Text.ToString());
                MessageBox.Show($"Added -->  Tag: {Tag.Text} / Value: {Value.Text}");
                Tag.Text = "";
                Value.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            Preview.Text = CurrXML;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PictureRad.Checked)
                {
                    ReturnedXML = SendXMLMessage(CreatePicMessage(MakePicString(ImagePath.Text.Trim())));
                }
                else if (UnitInfoRad.Checked)
                {
                    ReturnedXML = SendXMLMessage(CreateGetUnitInfoMessage());
                }
                else if (DCPRad.Checked)
                {
                    ReturnedXML = SendXMLMessage(CurrXML);
                    if (ReturnedXML == "")
                    {
                        MessageBox.Show("Error.. empty returned message..");
                        return;
                    }
                    else
                    {
                        ParseReturnMessage(ReturnedXML);
                    }
                }
                else if (StartRad.Checked)
                {
                    ReturnedXML = SendXMLMessage(CreateStartUnitMessage());
                }
                else
                {
                    MessageBox.Show("ERROR: No message option selected..");
                }
                Returned.Text = ReturnedXML;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private string MakePicString(string path)
        {
            using (Image image = Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    return Convert.ToBase64String(imageBytes);
                }
            }
        }

        public string CreateFeaturesPassedMessage()
        {
            StringBuilder xml = new StringBuilder();

            //Frame of message
            xml.Append(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mes=""http://mes.health.ge.com"" xmlns:sav=""http://saveDCP.mes.health.ge.com"">");
            xml.Append("<soapenv:Header/>");
            xml.Append("<soapenv:Body>");
            xml.Append("<mes:saveDCP>");
            xml.Append("<mes:in0>");
            xml.Append("<sav:completeOperation>0</sav:completeOperation>");
            xml.Append("<sav:consumedParts>");
            xml.Append("</sav:consumedParts>");
            xml.Append("<sav:dcps>");

            // Fill in dcp tags and values here
            for (int i = 0; i < dict.Count; i++)
            {
                xml.Append(CreateDCP(dict.Keys.ElementAt(i), dict[dict.Keys.ElementAt(i)]));
            }
            // End filling dcp tags and values

            xml.Append("</sav:dcps>");
            xml.Append($"<sav:operationName>{Operation.Text.Trim()}</sav:operationName>");
            xml.Append($"<sav:partNumber>{PartNumber.Text.Trim()}</sav:partNumber>");
            xml.Append($"<sav:partRevision>{PartRevision.Text.Trim()}</sav:partRevision>");
            xml.Append($"<sav:password>{Password.Text.Trim()}</sav:password>");
            xml.Append($"<sav:reasonCode>PASS</sav:reasonCode>");
            xml.Append($"<sav:routeName>{Route.Text.Trim()}</sav:routeName>");
            xml.Append($"<sav:serialNumber>{Serial.Text.Trim()}</sav:serialNumber>");
            xml.Append($"<sav:userID>{SSO.Text.Trim()}</sav:userID>");
            xml.Append("</mes:in0>");
            xml.Append("</mes:saveDCP>");
            xml.Append("</soapenv:Body>");
            xml.Append("</soapenv:Envelope>");

            return xml.ToString();
        }
        /*
         Operation.Text
        PartNumber.Text
        PartNumber.Text
        Route.Text
        SSO.Text
        Serial.Text
         */

        public string CreatePicMessage(string encodedImage)
        {
            StringBuilder xml = new StringBuilder();
            string userID = SSO.Text.Trim();
            string fileName = FileName.Text.Trim();
            string operationName = OperationName.Text.Trim();
            string partName = PartName.Text.Trim();
            string password = Password.Text.Trim();
            string partRevision = PartRevision.Text.Trim();
            string serialNumber = Serial.Text.Trim();
            string attachingUserID = AttachID.Text.Trim();
            string filePath = FilePath.Text.Trim();

            //Message Frame
            xml.Append(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mes=""http://mes.health.ge.com"" xmlns:sen=""http://sendAttachment.mes.health.ge.com"">");
            xml.Append("<soapenv:Header/>");
            xml.Append("<soapenv:Body>");
            xml.Append("<mes:sendAttachment>");
            xml.Append("<mes:in0>");

            // Start New Section
            xml.Append($"<sen:attachingUserID>{userID}</sen:attachingUserID>");
            xml.Append("<sen:attachmentFiles>");

            xml.Append("<sen:AttachmentFile>");

            xml.Append($"<sen:fileContent>{encodedImage}</sen:fileContent>");
            xml.Append($"<sen:fileName>{fileName }</sen:fileName>");
            xml.Append($"<sen:filePath>{filePath}</sen:filePath>");

            xml.Append("</sen:AttachmentFile>");

            xml.Append("</sen:attachmentFiles>");
            xml.Append($"<sen:operationName>{operationName}</sen:operationName>");
            xml.Append($"<sen:partName>{partName}</sen:partName>");
            xml.Append($"<sen:partRevision>{partRevision}</sen:partRevision>");
            xml.Append($"<sen:password>{password}</sen:password>");
            xml.Append($"<sen:serialNumber>{serialNumber}</sen:serialNumber>");
            xml.Append($"<sen:userID>{attachingUserID}</sen:userID>");
            // End New Section

            xml.Append("</mes:in0>");
            xml.Append("</mes:sendAttachment>");
            xml.Append("</soapenv:Body>");
            xml.Append("</soapenv:Envelope>");
            // End Frame

            return xml.ToString();

        }

        public string CreateGetUnitInfoMessage()
        {
            StringBuilder xml = new StringBuilder();
            xml.Append(@"<soapenv:Envelope xmlns:soapenv = ""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mes = ""http://mes.health.ge.com"" xmlns:get = ""http://getUnitInfo.mes.health.ge.com"">");
            xml.Append("<soapenv:Header/>");
            xml.Append("<soapenv:Body>");
            xml.Append("<mes:getUnitInfo>");
            xml.Append("<mes:in0>");

            xml.Append($"<get:password>{Password.Text.Trim()}</get:password>");
            xml.Append($"<get:serialNumber>{Serial.Text.Trim()}</get:serialNumber>");
            xml.Append($"<get:userID>{SSO.Text.Trim()}</get:userID>");

            xml.Append("</mes:in0>");
            xml.Append("</mes:getUnitInfo>");
            xml.Append("</soapenv:Body>");
            xml.Append("</soapenv:Envelope>");

            return xml.ToString();

            /*
            <soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:mes="http://mes.health.ge.com" xmlns:get="http://getUnitInfo.mes.health.ge.com">
                <soapenv:Header/>
                <soapenv:Body>
                    <mes:getUnitInfo>
                        <mes:in0>
                            <get:password>D1FaLMLucoDS.CLN1WA3GM6UCLN1WA3GM6UCLN1WA3GM6U</get:password>
                            <get:serialNumber>09999</get:serialNumber>
                            <get:userID>202123456</get:userID>
                        </mes:in0>
                </mes:getUnitInfo>
            </soapenv:Body>
            </soapenv:Envelope>
             */
        }

        public string CreateStartUnitMessage()
        {
            StringBuilder xml = new StringBuilder();

            // Start the frame
            xml.Append(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mes=""http://mes.health.ge.com"" xmlns:star=""http://startUnit.mes.health.ge.com"">");
            xml.Append("<soapenv:Header/>");
            xml.Append("<soapenv:Body>");
            xml.Append("<mes:startUnit>");
            xml.Append("<mes:in0>");

            // The guts
            xml.Append($"<star:operationName>{Operation.Text.Trim()}</star:operationName>");
            xml.Append($"<star:partName>{PartNumber.Text.Trim()}</star:partName>");
            xml.Append($"<star:partRevision>{PartRevision.Text.Trim()}</star:partRevision>");
            xml.Append($"<star:password>{Password.Text.Trim()}</star:password>");
            xml.Append($"<star:routeName>{Route.Text.Trim()}</star:routeName>");
            xml.Append($"<star:serialNumber>{Serial.Text.Trim()}</star:serialNumber>");
            xml.Append($"<star:userID>{SSO.Text.Trim()}</star:userID>");
            xml.Append($"<star:workCenter></star:workCenter>");

            // End the frame
            xml.Append("</mes:in0>");
            xml.Append("</mes:startUnit>");
            xml.Append("</soapenv:Body>");
            xml.Append("</soapenv:Envelope>");

            return xml.ToString();
        }

        public string CreateDCP(string tag, string value)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<sav:DCP>");
            sb.Append($"<sav:dcpImportTag>{tag}</sav:dcpImportTag>");
            sb.Append($"<sav:dcpValue>{value}</sav:dcpValue>");
            sb.Append("</sav:DCP>");
            return sb.ToString();
        }

        private string SendXMLMessage(string message)
        {
            string returnMessage = "";

            //Calling CreateSOAPWebRequest method    
            HttpWebRequest request = CreateSOAPWebRequest();

            XmlDocument SOAPReqBody = new XmlDocument();
            //SOAP Body Request    
            SOAPReqBody.LoadXml(message);

            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }

            //Geting response from request    
            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    //reading stream    
                    returnMessage = rd.ReadToEnd();
                }
            }

            return returnMessage;
        }

        public HttpWebRequest CreateSOAPWebRequest()
        {
            if (EndPoint.Text.ToString().Trim() == "")
            {
                throw new Exception("Error: Empty URL Endpoint..");
                
            }
            //Making Web Request    
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(EndPoint.Text.ToString());
            //Content_type    
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";
            //HTTP method    
            Req.Method = "POST";
            //return HttpWebRequest    
            return Req;
        }

        private bool ParseReturnMessage(string message)
        {
            string rawData = message;
            List<DCP> dcps = new List<DCP>();


            if (rawData.Trim() == "")
            {
                return false;
            }
            try
            {
                XDocument doc = XDocument.Parse(rawData);
                XNamespace ns = "http://mes.health.ge.com";
                XNamespace dcpns = "http://saveDCP.mes.health.ge.com";
                IEnumerable<XElement> responses = doc.Descendants(dcpns + "OutputDCP");

                foreach (XElement response in responses)
                {
                    string str1 = response.Descendants(dcpns + "dcpResult").Single().Value;
                    string str2 = response.Descendants(dcpns + "dctTag").Single().Value;
                    dcps.Add(new DCP(str2, str1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            // Check empty
            if (dcps.Count == 0)
            {
                // No DCPS returned
            }
            List<DCP> badDcps = new List<DCP>();

            // Check if any DCPS have a fail value
            foreach (DCP dcpResult in dcps)
            {
                // Error with this tag
                if (dcpResult.result.ToLower() != "accept")
                {
                    badDcps.Add(new DCP(dcpResult.tagNumber, dcpResult.result));
                }
            }

            // If size > 0 then there was an error in return tags
            if (badDcps.Count > 0)
            {
                // Notify user of errors on the tags
                return false;
            }
            return true;
        }

        private void PictureRad_CheckedChanged(object sender, EventArgs e)
        {
            if (PictureRad.Checked)
            {
                UnitInfoRad.Checked = false;
                DCPRad.Checked = false;
            }
        }

        private void UnitInfoRad_CheckedChanged(object sender, EventArgs e)
        {
            if (UnitInfoRad.Checked)
            {
                PictureRad.Checked = false;
                DCPRad.Checked = false;
            }
        }

        private void DCPRad_CheckedChanged(object sender, EventArgs e)
        {
            if (DCPRad.Checked)
            {
                PictureRad.Checked = false;
                UnitInfoRad.Checked = false;
            }
        }

        private void ResetDCPs_Click(object sender, EventArgs e)
        {
            dict.Clear();
            Preview.Text = "";
            Returned.Text = "";
        }

        private void UnlockBtn_Click(object sender, EventArgs e)
        {
            if (Unlock.Text.Trim() == "ge710")
            {
                Operation.Text = "UNS_VividELean_70";
                Route.Text = "UNS_VividELean_Manufacturing_Route";
                SSO.Text = "502702092";
                Password.Text = "D1NPnWPE5WwnE9vatgdNzUFICLN1WA3GM6UCLN1WA3GM6U";
                EndPoint.Text = @"http://HCUSALPMESVMS5.logon.ds.ge.com:8084/MachineConnectivity/IWebService";

                PartNumber.Text = "";
                Serial.Text = "";
            }
        }
    }
}
