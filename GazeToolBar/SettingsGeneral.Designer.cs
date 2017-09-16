namespace GazeToolBar
{
    partial class SettingsGeneral
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
            this.pnlFixationTimeOut = new System.Windows.Forms.Panel();
            this.pnlFixTimeOutContent = new System.Windows.Forms.Panel();
            this.pnlFTOPlus = new System.Windows.Forms.Panel();
            this.btnFixTimeOutPlus = new System.Windows.Forms.Button();
            this.trackBarFixTimeOut = new System.Windows.Forms.TrackBar();
            this.pnlFTOMins = new System.Windows.Forms.Panel();
            this.btnFixTimeOutMins = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.panelPrecision = new System.Windows.Forms.Panel();
            this.pnlFixTimeLengthContent = new System.Windows.Forms.Panel();
            this.pnlFTLPlus = new System.Windows.Forms.Panel();
            this.btnFixTimeLengthPlus = new System.Windows.Forms.Button();
            this.trackBarFixTimeLength = new System.Windows.Forms.TrackBar();
            this.pnlFTLMins = new System.Windows.Forms.Panel();
            this.btnFixTimeLengthMins = new System.Windows.Forms.Button();
            this.lblFixationDetectionTimeLength = new System.Windows.Forms.Label();
            this.pnlOtherAuto = new System.Windows.Forms.Panel();
            this.btnAutoStart = new System.Windows.Forms.Button();
            this.pnlAuto = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFixationTimeOut.SuspendLayout();
            this.pnlFixTimeOutContent.SuspendLayout();
            this.pnlFTOPlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFixTimeOut)).BeginInit();
            this.pnlFTOMins.SuspendLayout();
            this.panelPrecision.SuspendLayout();
            this.pnlFixTimeLengthContent.SuspendLayout();
            this.pnlFTLPlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFixTimeLength)).BeginInit();
            this.pnlFTLMins.SuspendLayout();
            this.pnlOtherAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFixationTimeOut
            // 
            this.pnlFixationTimeOut.BackColor = System.Drawing.Color.Black;
            this.pnlFixationTimeOut.Controls.Add(this.pnlFixTimeOutContent);
            this.pnlFixationTimeOut.Controls.Add(this.lblSpeed);
            this.pnlFixationTimeOut.Location = new System.Drawing.Point(11, 348);
            this.pnlFixationTimeOut.Name = "pnlFixationTimeOut";
            this.pnlFixationTimeOut.Size = new System.Drawing.Size(1243, 118);
            this.pnlFixationTimeOut.TabIndex = 33;
            // 
            // pnlFixTimeOutContent
            // 
            this.pnlFixTimeOutContent.BackColor = System.Drawing.Color.Black;
            this.pnlFixTimeOutContent.Controls.Add(this.pnlFTOPlus);
            this.pnlFixTimeOutContent.Controls.Add(this.trackBarFixTimeOut);
            this.pnlFixTimeOutContent.Controls.Add(this.pnlFTOMins);
            this.pnlFixTimeOutContent.Location = new System.Drawing.Point(174, 18);
            this.pnlFixTimeOutContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFixTimeOutContent.Name = "pnlFixTimeOutContent";
            this.pnlFixTimeOutContent.Size = new System.Drawing.Size(1000, 72);
            this.pnlFixTimeOutContent.TabIndex = 22;
            // 
            // pnlFTOPlus
            // 
            this.pnlFTOPlus.Controls.Add(this.btnFixTimeOutPlus);
            this.pnlFTOPlus.Location = new System.Drawing.Point(951, 13);
            this.pnlFTOPlus.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFTOPlus.Name = "pnlFTOPlus";
            this.pnlFTOPlus.Size = new System.Drawing.Size(45, 46);
            this.pnlFTOPlus.TabIndex = 23;
            // 
            // btnFixTimeOutPlus
            // 
            this.btnFixTimeOutPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnFixTimeOutPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixTimeOutPlus.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFixTimeOutPlus.ForeColor = System.Drawing.Color.White;
            this.btnFixTimeOutPlus.Location = new System.Drawing.Point(2, 2);
            this.btnFixTimeOutPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnFixTimeOutPlus.Name = "btnFixTimeOutPlus";
            this.btnFixTimeOutPlus.Size = new System.Drawing.Size(41, 41);
            this.btnFixTimeOutPlus.TabIndex = 16;
            this.btnFixTimeOutPlus.Text = "+";
            this.btnFixTimeOutPlus.UseVisualStyleBackColor = false;
            this.btnFixTimeOutPlus.Click += new System.EventHandler(this.btnFixTimeOutPlus_Click);
            // 
            // trackBarFixTimeOut
            // 
            this.trackBarFixTimeOut.Location = new System.Drawing.Point(52, 13);
            this.trackBarFixTimeOut.Name = "trackBarFixTimeOut";
            this.trackBarFixTimeOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarFixTimeOut.Size = new System.Drawing.Size(894, 45);
            this.trackBarFixTimeOut.TabIndex = 15;
            this.trackBarFixTimeOut.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarFixTimeOut.Value = 5;
            this.trackBarFixTimeOut.ValueChanged += new System.EventHandler(this.trackBarFixTimeOut_ValueChanged);
            // 
            // pnlFTOMins
            // 
            this.pnlFTOMins.Controls.Add(this.btnFixTimeOutMins);
            this.pnlFTOMins.Location = new System.Drawing.Point(2, 13);
            this.pnlFTOMins.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFTOMins.Name = "pnlFTOMins";
            this.pnlFTOMins.Size = new System.Drawing.Size(45, 46);
            this.pnlFTOMins.TabIndex = 22;
            // 
            // btnFixTimeOutMins
            // 
            this.btnFixTimeOutMins.BackColor = System.Drawing.Color.Transparent;
            this.btnFixTimeOutMins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixTimeOutMins.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFixTimeOutMins.ForeColor = System.Drawing.Color.White;
            this.btnFixTimeOutMins.Location = new System.Drawing.Point(2, 2);
            this.btnFixTimeOutMins.Margin = new System.Windows.Forms.Padding(2);
            this.btnFixTimeOutMins.Name = "btnFixTimeOutMins";
            this.btnFixTimeOutMins.Size = new System.Drawing.Size(41, 41);
            this.btnFixTimeOutMins.TabIndex = 17;
            this.btnFixTimeOutMins.Text = "-";
            this.btnFixTimeOutMins.UseVisualStyleBackColor = false;
            this.btnFixTimeOutMins.Click += new System.EventHandler(this.btnFixTimeOutMins_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(14, 31);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(80, 32);
            this.lblSpeed.TabIndex = 14;
            this.lblSpeed.Text = "Fixation \r\nTime Out";
            // 
            // panelPrecision
            // 
            this.panelPrecision.BackColor = System.Drawing.Color.Black;
            this.panelPrecision.Controls.Add(this.pnlFixTimeLengthContent);
            this.panelPrecision.Controls.Add(this.lblFixationDetectionTimeLength);
            this.panelPrecision.Location = new System.Drawing.Point(11, 215);
            this.panelPrecision.Name = "panelPrecision";
            this.panelPrecision.Size = new System.Drawing.Size(1243, 115);
            this.panelPrecision.TabIndex = 32;
            // 
            // pnlFixTimeLengthContent
            // 
            this.pnlFixTimeLengthContent.BackColor = System.Drawing.Color.Black;
            this.pnlFixTimeLengthContent.Controls.Add(this.pnlFTLPlus);
            this.pnlFixTimeLengthContent.Controls.Add(this.trackBarFixTimeLength);
            this.pnlFixTimeLengthContent.Controls.Add(this.pnlFTLMins);
            this.pnlFixTimeLengthContent.Location = new System.Drawing.Point(172, 20);
            this.pnlFixTimeLengthContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFixTimeLengthContent.Name = "pnlFixTimeLengthContent";
            this.pnlFixTimeLengthContent.Size = new System.Drawing.Size(1000, 72);
            this.pnlFixTimeLengthContent.TabIndex = 22;
            // 
            // pnlFTLPlus
            // 
            this.pnlFTLPlus.Controls.Add(this.btnFixTimeLengthPlus);
            this.pnlFTLPlus.Location = new System.Drawing.Point(953, 9);
            this.pnlFTLPlus.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFTLPlus.Name = "pnlFTLPlus";
            this.pnlFTLPlus.Size = new System.Drawing.Size(45, 46);
            this.pnlFTLPlus.TabIndex = 23;
            // 
            // btnFixTimeLengthPlus
            // 
            this.btnFixTimeLengthPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnFixTimeLengthPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixTimeLengthPlus.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFixTimeLengthPlus.ForeColor = System.Drawing.Color.White;
            this.btnFixTimeLengthPlus.Location = new System.Drawing.Point(2, 2);
            this.btnFixTimeLengthPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnFixTimeLengthPlus.Name = "btnFixTimeLengthPlus";
            this.btnFixTimeLengthPlus.Size = new System.Drawing.Size(41, 41);
            this.btnFixTimeLengthPlus.TabIndex = 13;
            this.btnFixTimeLengthPlus.Text = "+";
            this.btnFixTimeLengthPlus.UseVisualStyleBackColor = false;
            this.btnFixTimeLengthPlus.Click += new System.EventHandler(this.btnFixTimeLengthPlus_Click);
            // 
            // trackBarFixTimeLength
            // 
            this.trackBarFixTimeLength.BackColor = System.Drawing.Color.Black;
            this.trackBarFixTimeLength.Location = new System.Drawing.Point(52, 9);
            this.trackBarFixTimeLength.Name = "trackBarFixTimeLength";
            this.trackBarFixTimeLength.Size = new System.Drawing.Size(896, 45);
            this.trackBarFixTimeLength.TabIndex = 12;
            this.trackBarFixTimeLength.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarFixTimeLength.Value = 5;
            this.trackBarFixTimeLength.ValueChanged += new System.EventHandler(this.trackBarFixTimeLength_ValueChanged);
            // 
            // pnlFTLMins
            // 
            this.pnlFTLMins.Controls.Add(this.btnFixTimeLengthMins);
            this.pnlFTLMins.Location = new System.Drawing.Point(2, 9);
            this.pnlFTLMins.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFTLMins.Name = "pnlFTLMins";
            this.pnlFTLMins.Size = new System.Drawing.Size(45, 46);
            this.pnlFTLMins.TabIndex = 22;
            // 
            // btnFixTimeLengthMins
            // 
            this.btnFixTimeLengthMins.BackColor = System.Drawing.Color.Transparent;
            this.btnFixTimeLengthMins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixTimeLengthMins.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFixTimeLengthMins.ForeColor = System.Drawing.Color.White;
            this.btnFixTimeLengthMins.Location = new System.Drawing.Point(2, 2);
            this.btnFixTimeLengthMins.Margin = new System.Windows.Forms.Padding(2);
            this.btnFixTimeLengthMins.Name = "btnFixTimeLengthMins";
            this.btnFixTimeLengthMins.Size = new System.Drawing.Size(41, 41);
            this.btnFixTimeLengthMins.TabIndex = 14;
            this.btnFixTimeLengthMins.Text = "-";
            this.btnFixTimeLengthMins.UseVisualStyleBackColor = false;
            this.btnFixTimeLengthMins.Click += new System.EventHandler(this.btnFixTimeLengthMins_Click);
            // 
            // lblFixationDetectionTimeLength
            // 
            this.lblFixationDetectionTimeLength.AutoSize = true;
            this.lblFixationDetectionTimeLength.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblFixationDetectionTimeLength.ForeColor = System.Drawing.Color.White;
            this.lblFixationDetectionTimeLength.Location = new System.Drawing.Point(14, 33);
            this.lblFixationDetectionTimeLength.Name = "lblFixationDetectionTimeLength";
            this.lblFixationDetectionTimeLength.Size = new System.Drawing.Size(96, 32);
            this.lblFixationDetectionTimeLength.TabIndex = 11;
            this.lblFixationDetectionTimeLength.Text = "Fixation \r\nTime Length";
            // 
            // pnlOtherAuto
            // 
            this.pnlOtherAuto.BackColor = System.Drawing.Color.Black;
            this.pnlOtherAuto.Controls.Add(this.btnAutoStart);
            this.pnlOtherAuto.Controls.Add(this.pnlAuto);
            this.pnlOtherAuto.Controls.Add(this.label2);
            this.pnlOtherAuto.Location = new System.Drawing.Point(620, 492);
            this.pnlOtherAuto.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOtherAuto.Name = "pnlOtherAuto";
            this.pnlOtherAuto.Size = new System.Drawing.Size(150, 120);
            this.pnlOtherAuto.TabIndex = 34;
            // 
            // btnAutoStart
            // 
            this.btnAutoStart.BackColor = System.Drawing.Color.Black;
            this.btnAutoStart.FlatAppearance.BorderSize = 5;
            this.btnAutoStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoStart.ForeColor = System.Drawing.Color.White;
            this.btnAutoStart.Location = new System.Drawing.Point(92, 62);
            this.btnAutoStart.Name = "btnAutoStart";
            this.btnAutoStart.Size = new System.Drawing.Size(55, 55);
            this.btnAutoStart.TabIndex = 4;
            this.btnAutoStart.UseVisualStyleBackColor = false;
            this.btnAutoStart.Click += new System.EventHandler(this.btnAutoStart_Click);
            // 
            // pnlAuto
            // 
            this.pnlAuto.Location = new System.Drawing.Point(31, 69);
            this.pnlAuto.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAuto.Name = "pnlAuto";
            this.pnlAuto.Size = new System.Drawing.Size(59, 59);
            this.pnlAuto.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Auto start";
            // 
            // SettingsGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlOtherAuto);
            this.Controls.Add(this.pnlFixationTimeOut);
            this.Controls.Add(this.panelPrecision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsGeneral";
            this.Text = "SettingsGeneral";
            this.Load += new System.EventHandler(this.SettingsGeneral_Load);
            this.Controls.SetChildIndex(this.panelPrecision, 0);
            this.Controls.SetChildIndex(this.pnlFixationTimeOut, 0);
            this.Controls.SetChildIndex(this.pnlOtherAuto, 0);
            this.pnlFixationTimeOut.ResumeLayout(false);
            this.pnlFixationTimeOut.PerformLayout();
            this.pnlFixTimeOutContent.ResumeLayout(false);
            this.pnlFixTimeOutContent.PerformLayout();
            this.pnlFTOPlus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFixTimeOut)).EndInit();
            this.pnlFTOMins.ResumeLayout(false);
            this.panelPrecision.ResumeLayout(false);
            this.panelPrecision.PerformLayout();
            this.pnlFixTimeLengthContent.ResumeLayout(false);
            this.pnlFixTimeLengthContent.PerformLayout();
            this.pnlFTLPlus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFixTimeLength)).EndInit();
            this.pnlFTLMins.ResumeLayout(false);
            this.pnlOtherAuto.ResumeLayout(false);
            this.pnlOtherAuto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EyeXFramework.Forms.BehaviorMap bhavSettingMap;
        private System.Windows.Forms.Panel pnlFixationTimeOut;
        private System.Windows.Forms.Panel pnlFixTimeOutContent;
        private System.Windows.Forms.Panel pnlFTOPlus;
        private System.Windows.Forms.Button btnFixTimeOutPlus;
        private System.Windows.Forms.TrackBar trackBarFixTimeOut;
        private System.Windows.Forms.Panel pnlFTOMins;
        private System.Windows.Forms.Button btnFixTimeOutMins;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Panel panelPrecision;
        private System.Windows.Forms.Panel pnlFixTimeLengthContent;
        private System.Windows.Forms.Panel pnlFTLPlus;
        private System.Windows.Forms.Button btnFixTimeLengthPlus;
        private System.Windows.Forms.TrackBar trackBarFixTimeLength;
        private System.Windows.Forms.Panel pnlFTLMins;
        private System.Windows.Forms.Button btnFixTimeLengthMins;
        private System.Windows.Forms.Label lblFixationDetectionTimeLength;
        private System.Windows.Forms.Panel pnlOtherAuto;
        private System.Windows.Forms.Panel pnlAuto;
        private System.Windows.Forms.Button btnAutoStart;
        private System.Windows.Forms.Label label2;
    }
}