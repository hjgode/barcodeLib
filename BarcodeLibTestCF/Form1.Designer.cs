namespace BarcodeLibTestCF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkGenerateLabel = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.cbEncodeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.barcode = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(111, 243);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(91, 21);
            this.txtHeight.TabIndex = 61;
            this.txtHeight.Text = "60";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(3, 243);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(90, 21);
            this.txtWidth.TabIndex = 60;
            this.txtWidth.Text = "200";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(111, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.Text = "Height";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.Text = "Width";
            // 
            // chkGenerateLabel
            // 
            this.chkGenerateLabel.Location = new System.Drawing.Point(113, 7);
            this.chkGenerateLabel.Name = "chkGenerateLabel";
            this.chkGenerateLabel.Size = new System.Drawing.Size(107, 17);
            this.chkGenerateLabel.TabIndex = 59;
            this.chkGenerateLabel.Text = "Generate label";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(111, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.Text = "Background Color";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.Text = "Foreground Color";
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(111, 201);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(91, 23);
            this.btnBackColor.TabIndex = 58;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click_1);
            // 
            // btnForeColor
            // 
            this.btnForeColor.Location = new System.Drawing.Point(3, 201);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(91, 23);
            this.btnForeColor.TabIndex = 57;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click_1);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.Text = "Encoding";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(145, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "&Save As";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(145, 51);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 54;
            this.btnEncode.Text = "&Encode";
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click_1);
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.Items.Add("UPC-A");
            this.cbEncodeType.Items.Add("UPC-E");
            this.cbEncodeType.Items.Add("UPC 2 Digit Ext.");
            this.cbEncodeType.Items.Add("UPC 5 Digit Ext.");
            this.cbEncodeType.Items.Add("EAN-13");
            this.cbEncodeType.Items.Add("JAN-13");
            this.cbEncodeType.Items.Add("EAN-8");
            this.cbEncodeType.Items.Add("ITF-14");
            this.cbEncodeType.Items.Add("Interleaved 2 of 5");
            this.cbEncodeType.Items.Add("Standard 2 of 5");
            this.cbEncodeType.Items.Add("Codabar");
            this.cbEncodeType.Items.Add("PostNet");
            this.cbEncodeType.Items.Add("Bookland/ISBN");
            this.cbEncodeType.Items.Add("Code 11");
            this.cbEncodeType.Items.Add("Code 39");
            this.cbEncodeType.Items.Add("Code 39 Extended");
            this.cbEncodeType.Items.Add("Code 93");
            this.cbEncodeType.Items.Add("Code 128");
            this.cbEncodeType.Items.Add("Code 128-A");
            this.cbEncodeType.Items.Add("Code 128-B");
            this.cbEncodeType.Items.Add("Code 128-C");
            this.cbEncodeType.Items.Add("LOGMARS");
            this.cbEncodeType.Items.Add("MSI");
            this.cbEncodeType.Location = new System.Drawing.Point(6, 81);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(121, 22);
            this.cbEncodeType.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.Text = "Encoded Value";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(5, 27);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(215, 21);
            this.txtData.TabIndex = 52;
            this.txtData.Text = "038000356216";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.Text = "Value to Encode";
            // 
            // txtEncoded
            // 
            this.txtEncoded.Location = new System.Drawing.Point(3, 294);
            this.txtEncoded.Multiline = true;
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.ReadOnly = true;
            this.txtEncoded.Size = new System.Drawing.Size(212, 47);
            this.txtEncoded.TabIndex = 56;
            this.txtEncoded.TabStop = false;
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(6, 112);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(214, 70);
            this.barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkGenerateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.btnForeColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.cbEncodeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncoded);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BarcodeLibCF Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkGenerateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncoded;
        private System.Windows.Forms.PictureBox barcode;
    }
}

