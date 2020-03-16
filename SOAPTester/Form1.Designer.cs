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
            this.SuspendLayout();
            // 
            // EndPoint
            // 
            this.EndPoint.Location = new System.Drawing.Point(12, 27);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(279, 20);
            this.EndPoint.TabIndex = 0;
            // 
            // AddDcpBtn
            // 
            this.AddDcpBtn.Location = new System.Drawing.Point(224, 75);
            this.AddDcpBtn.Name = "AddDcpBtn";
            this.AddDcpBtn.Size = new System.Drawing.Size(75, 23);
            this.AddDcpBtn.TabIndex = 3;
            this.AddDcpBtn.Text = "ADD DCP";
            this.AddDcpBtn.UseVisualStyleBackColor = true;
            this.AddDcpBtn.Click += new System.EventHandler(this.AddDcpBtn_Click);
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(12, 145);
            this.Preview.Multiline = true;
            this.Preview.Name = "Preview";
            this.Preview.ReadOnly = true;
            this.Preview.Size = new System.Drawing.Size(380, 293);
            this.Preview.TabIndex = 4;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(118, 78);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 20);
            this.Value.TabIndex = 2;
            // 
            // Tag
            // 
            this.Tag.Location = new System.Drawing.Point(12, 78);
            this.Tag.Name = "Tag";
            this.Tag.Size = new System.Drawing.Size(100, 20);
            this.Tag.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Endpoint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tag";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(674, 12);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(114, 43);
            this.SendBtn.TabIndex = 5;
            this.SendBtn.Text = "Send Message";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "XML Raw Preview";
            // 
            // PreviewBtn
            // 
            this.PreviewBtn.Location = new System.Drawing.Point(301, 116);
            this.PreviewBtn.Name = "PreviewBtn";
            this.PreviewBtn.Size = new System.Drawing.Size(91, 23);
            this.PreviewBtn.TabIndex = 4;
            this.PreviewBtn.Text = "Show Preview";
            this.PreviewBtn.UseVisualStyleBackColor = true;
            this.PreviewBtn.Click += new System.EventHandler(this.PreviewBtn_Click);
            // 
            // Returned
            // 
            this.Returned.Location = new System.Drawing.Point(408, 145);
            this.Returned.Multiline = true;
            this.Returned.Name = "Returned";
            this.Returned.ReadOnly = true;
            this.Returned.Size = new System.Drawing.Size(380, 293);
            this.Returned.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Return Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

