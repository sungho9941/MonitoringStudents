namespace MonitoringStudents
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timCapture = new System.Windows.Forms.Timer(this.components);
            this.picFrame = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnDetect = new System.Windows.Forms.Button();
            this.picGrayscale = new System.Windows.Forms.PictureBox();
            this.txtHuddle = new System.Windows.Forms.TextBox();
            this.laMessage = new System.Windows.Forms.Label();
            this.txtMailAddress = new System.Windows.Forms.TextBox();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrayscale)).BeginInit();
            this.gbSetting.SuspendLayout();
            this.gbPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // timCapture
            // 
            this.timCapture.Tick += new System.EventHandler(this.timCapture_Tick);
            // 
            // picFrame
            // 
            this.picFrame.Location = new System.Drawing.Point(22, 20);
            this.picFrame.Margin = new System.Windows.Forms.Padding(5);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(1152, 800);
            this.picFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrame.TabIndex = 1;
            this.picFrame.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(958, 720);
            this.btnTest.Margin = new System.Windows.Forms.Padding(5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(216, 100);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(1539, 720);
            this.btnDetect.Margin = new System.Windows.Forms.Padding(5);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(216, 100);
            this.btnDetect.TabIndex = 2;
            this.btnDetect.Text = "Start";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // picGrayscale
            // 
            this.picGrayscale.BackColor = System.Drawing.Color.Black;
            this.picGrayscale.Location = new System.Drawing.Point(29, 59);
            this.picGrayscale.Name = "picGrayscale";
            this.picGrayscale.Size = new System.Drawing.Size(514, 326);
            this.picGrayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrayscale.TabIndex = 3;
            this.picGrayscale.TabStop = false;
            // 
            // txtHuddle
            // 
            this.txtHuddle.Location = new System.Drawing.Point(172, 63);
            this.txtHuddle.Name = "txtHuddle";
            this.txtHuddle.Size = new System.Drawing.Size(371, 42);
            this.txtHuddle.TabIndex = 4;
            this.txtHuddle.Text = "220";
            this.txtHuddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // laMessage
            // 
            this.laMessage.AutoSize = true;
            this.laMessage.BackColor = System.Drawing.Color.Transparent;
            this.laMessage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.laMessage.ForeColor = System.Drawing.Color.Red;
            this.laMessage.Location = new System.Drawing.Point(43, 86);
            this.laMessage.Name = "laMessage";
            this.laMessage.Size = new System.Drawing.Size(0, 30);
            this.laMessage.TabIndex = 5;
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.Location = new System.Drawing.Point(172, 128);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.Size = new System.Drawing.Size(371, 42);
            this.txtMailAddress.TabIndex = 4;
            this.txtMailAddress.Text = "swordlevross@nate.com";
            this.txtMailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.label5);
            this.gbSetting.Controls.Add(this.label4);
            this.gbSetting.Controls.Add(this.label3);
            this.gbSetting.Controls.Add(this.label2);
            this.gbSetting.Controls.Add(this.label1);
            this.gbSetting.Controls.Add(this.txtHuddle);
            this.gbSetting.Controls.Add(this.txtMinute);
            this.gbSetting.Controls.Add(this.txtHour);
            this.gbSetting.Controls.Add(this.txtMailAddress);
            this.gbSetting.Location = new System.Drawing.Point(1182, 20);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(573, 271);
            this.gbSetting.TabIndex = 6;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "분";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "시";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(19, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reporting Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "메일주소";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "기준";
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(396, 197);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(92, 42);
            this.txtMinute.TabIndex = 4;
            this.txtMinute.Text = "59";
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(249, 197);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(92, 42);
            this.txtHour.TabIndex = 4;
            this.txtHour.Text = "23";
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.picGrayscale);
            this.gbPreview.Location = new System.Drawing.Point(1182, 306);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(573, 406);
            this.gbPreview.TabIndex = 6;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Binary Image";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 852);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.gbSetting);
            this.Controls.Add(this.laMessage);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.picFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monitoring Students(■)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrayscale)).EndInit();
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            this.gbPreview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timCapture;
        private OpenCvSharp.UserInterface.PictureBoxIpl picFrame;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.PictureBox picGrayscale;
        private System.Windows.Forms.TextBox txtHuddle;
        private System.Windows.Forms.Label laMessage;
        private System.Windows.Forms.TextBox txtMailAddress;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.GroupBox gbPreview;
    }
}

