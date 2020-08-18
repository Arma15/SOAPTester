namespace SOAPTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EndPoint = new System.Windows.Forms.TextBox();
            this.AddDcpBtn = new System.Windows.Forms.Button();
            this.Preview = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.Tag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PreviewBtn = new System.Windows.Forms.Button();
            this.Returned = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PictureRad = new System.Windows.Forms.RadioButton();
            this.ImagePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndPoint
            // 
            this.EndPoint.Location = new System.Drawing.Point(18, 42);
            this.EndPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(416, 26);
            this.EndPoint.TabIndex = 0;
            // 
            // AddDcpBtn
            // 
            this.AddDcpBtn.Location = new System.Drawing.Point(336, 115);
            this.AddDcpBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddDcpBtn.Name = "AddDcpBtn";
            this.AddDcpBtn.Size = new System.Drawing.Size(112, 35);
            this.AddDcpBtn.TabIndex = 3;
            this.AddDcpBtn.Text = "ADD DCP";
            this.AddDcpBtn.UseVisualStyleBackColor = true;
            this.AddDcpBtn.Click += new System.EventHandler(this.AddDcpBtn_Click);
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(18, 223);
            this.Preview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Preview.Multiline = true;
            this.Preview.Name = "Preview";
            this.Preview.ReadOnly = true;
            this.Preview.Size = new System.Drawing.Size(568, 449);
            this.Preview.TabIndex = 4;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(177, 120);
            this.Value.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(148, 26);
            this.Value.TabIndex = 2;
            // 
            // Tag
            // 
            this.Tag.Location = new System.Drawing.Point(18, 120);
            this.Tag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tag.Name = "Tag";
            this.Tag.Size = new System.Drawing.Size(148, 26);
            this.Tag.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Endpoint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tag";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(1011, 18);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(171, 66);
            this.SendBtn.TabIndex = 5;
            this.SendBtn.Text = "Send Message";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "XML Raw Preview";
            // 
            // PreviewBtn
            // 
            this.PreviewBtn.Location = new System.Drawing.Point(452, 178);
            this.PreviewBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreviewBtn.Name = "PreviewBtn";
            this.PreviewBtn.Size = new System.Drawing.Size(136, 35);
            this.PreviewBtn.TabIndex = 4;
            this.PreviewBtn.Text = "Show Preview";
            this.PreviewBtn.UseVisualStyleBackColor = true;
            this.PreviewBtn.Click += new System.EventHandler(this.PreviewBtn_Click);
            // 
            // Returned
            // 
            this.Returned.Location = new System.Drawing.Point(612, 223);
            this.Returned.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Returned.Multiline = true;
            this.Returned.Name = "Returned";
            this.Returned.ReadOnly = true;
            this.Returned.Size = new System.Drawing.Size(568, 449);
            this.Returned.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(842, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Return Message";
            // 
            // PictureRad
            // 
            this.PictureRad.AutoSize = true;
            this.PictureRad.Location = new System.Drawing.Point(612, 44);
            this.PictureRad.Name = "PictureRad";
            this.PictureRad.Size = new System.Drawing.Size(124, 24);
            this.PictureRad.TabIndex = 15;
            this.PictureRad.TabStop = true;
            this.PictureRad.Text = "Pic Message";
            this.PictureRad.UseVisualStyleBackColor = true;
            // 
            // ImagePath
            // 
            this.ImagePath.Location = new System.Drawing.Point(502, 92);
            this.ImagePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.Size = new System.Drawing.Size(416, 26);
            this.ImagePath.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Image Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ImagePath);
            this.Controls.Add(this.PictureRad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Returned);
            this.Controls.Add(this.PreviewBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tag);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.AddDcpBtn);
            this.Controls.Add(this.EndPoint);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SOAPTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EndPoint;
        private System.Windows.Forms.Button AddDcpBtn;
        private System.Windows.Forms.TextBox Preview;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox Tag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PreviewBtn;
        private System.Windows.Forms.TextBox Returned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton PictureRad;
        private System.Windows.Forms.TextBox ImagePath;
        private System.Windows.Forms.Label label6;
    }
}

