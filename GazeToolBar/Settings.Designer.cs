using System.Windows.Forms;

namespace GazeToolBar
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.bhavSettingMap = new EyeXFramework.Forms.BehaviorMap(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelSaveAndCancel = new System.Windows.Forms.Panel();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.pnlPageKeyboard = new System.Windows.Forms.Panel();
            this.lbFKeyFeedback = new System.Windows.Forms.Label();
            this.pnlRightClick = new System.Windows.Forms.Panel();
            this.lbRight = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlFKeyHighlight3 = new System.Windows.Forms.Panel();
            this.btFKeyRightClick = new System.Windows.Forms.Button();
            this.pnlFKeyHighlight4 = new System.Windows.Forms.Panel();
            this.btClearFKeyRightClick = new System.Windows.Forms.Button();
            this.pnlDoubleClick = new System.Windows.Forms.Panel();
            this.lbDouble = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlFKeyHighlight5 = new System.Windows.Forms.Panel();
            this.btFKeyDoubleClick = new System.Windows.Forms.Button();
            this.pnlFKeyHighlight6 = new System.Windows.Forms.Panel();
            this.btClearFKeyDoubleClick = new System.Windows.Forms.Button();
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.lbScroll = new System.Windows.Forms.Label();
            this.pnlFKeyHighlight8 = new System.Windows.Forms.Panel();
            this.btClearFKeyScroll = new System.Windows.Forms.Button();
            this.pnlFKeyHighlight7 = new System.Windows.Forms.Panel();
            this.btFKeyScroll = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlLeftClick = new System.Windows.Forms.Panel();
            this.pnlFKeyHighlight2 = new System.Windows.Forms.Panel();
            this.btClearFKeyLeftClick = new System.Windows.Forms.Button();
            this.pnlFKeyHighlight1 = new System.Windows.Forms.Panel();
            this.btFKeyLeftClick = new System.Windows.Forms.Button();
            this.lbLeft = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFKeyHighlight10 = new System.Windows.Forms.Panel();
            this.btClearFKeyDrapAndDrop = new System.Windows.Forms.Button();
            this.pnlFKeyHighlight9 = new System.Windows.Forms.Panel();
            this.btFKeyDrapAndDrop = new System.Windows.Forms.Button();
            this.btnGeneralSetting = new System.Windows.Forms.Button();
            this.btnShortCutKeySetting = new System.Windows.Forms.Button();
            this.pnlGeneralButton = new System.Windows.Forms.Panel();
            this.pnlKeysButton = new System.Windows.Forms.Panel();
            this.pnlSwitchSetting = new System.Windows.Forms.Panel();
            this.pnlRearrangeButton = new System.Windows.Forms.Panel();
            this.btnRearrangeSetting = new System.Windows.Forms.Button();
            this.pnlZoomButton = new System.Windows.Forms.Panel();
            this.btnZoomSettings = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlZoomSize = new System.Windows.Forms.Panel();
            this.pnlZoomSizeContent = new System.Windows.Forms.Panel();
            this.pnlZWSPlus = new System.Windows.Forms.Panel();
            this.btnZoomSizePlus = new System.Windows.Forms.Button();
            this.trackBarZoomWindowSize = new System.Windows.Forms.TrackBar();
            this.pnlZWSMinus = new System.Windows.Forms.Panel();
            this.btnZoomSizeMinus = new System.Windows.Forms.Button();
            this.labZoomWindowSize = new System.Windows.Forms.Label();
            this.pnlZoomAmount = new System.Windows.Forms.Panel();
            this.pnlZoomAmountContent = new System.Windows.Forms.Panel();
            this.pnlZIAPlus = new System.Windows.Forms.Panel();
            this.btnZoomAmountPlus = new System.Windows.Forms.Button();
            this.trackBarZoomAmount = new System.Windows.Forms.TrackBar();
            this.pnlZIAMinus = new System.Windows.Forms.Panel();
            this.btnZoomAmountMinus = new System.Windows.Forms.Button();
            this.labZoomAmount = new System.Windows.Forms.Label();
            this.pnlZoomSettings = new System.Windows.Forms.Panel();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.pnlFixationTimeOut = new System.Windows.Forms.Panel();
            this.pnlFixTimeOutContent = new System.Windows.Forms.Panel();
            this.pnlFTOPlus = new System.Windows.Forms.Panel();
            this.btnFixTimeOutPlus = new System.Windows.Forms.Button();
            this.trackBarFixTimeOut = new System.Windows.Forms.TrackBar();
            this.pnlFTOMins = new System.Windows.Forms.Panel();
            this.btnFixTimeOutMins = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.panelOther = new System.Windows.Forms.Panel();
            this.pnlOtherAuto = new System.Windows.Forms.Panel();
            this.pnlAuto = new System.Windows.Forms.Panel();
            this.btnAutoStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.panelPrecision = new System.Windows.Forms.Panel();
            this.pnlFixTimeLengthContent = new System.Windows.Forms.Panel();
            this.pnlFTLPlus = new System.Windows.Forms.Panel();
            this.btnFixTimeLengthPlus = new System.Windows.Forms.Button();
            this.trackBarFixTimeLength = new System.Windows.Forms.TrackBar();
            this.pnlFTLMins = new System.Windows.Forms.Panel();
            this.btnFixTimeLengthMins = new System.Windows.Forms.Button();
            this.lblFixationDetectionTimeLength = new System.Windows.Forms.Label();
            this.pnlRearrange = new System.Windows.Forms.Panel();
            this.pnlRearrangeControls = new System.Windows.Forms.Panel();
            this.pnlMoveUpButton = new System.Windows.Forms.Panel();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.pnlMoveDownButton = new System.Windows.Forms.Panel();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.pnlRemoveButton = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlRightClickButton = new System.Windows.Forms.Panel();
            this.btnActionRightClick = new System.Windows.Forms.Button();
            this.pnlSettingsButton = new System.Windows.Forms.Panel();
            this.btnActionSettings = new System.Windows.Forms.Button();
            this.pnlLeftClickButton = new System.Windows.Forms.Panel();
            this.btnActionLeftClick = new System.Windows.Forms.Button();
            this.pnlKeyboardButton = new System.Windows.Forms.Panel();
            this.btnActionKeyboard = new System.Windows.Forms.Button();
            this.pnlScrollClickButton = new System.Windows.Forms.Panel();
            this.btnActionScrollClick = new System.Windows.Forms.Button();
            this.pnlDoubleLeftClickButton = new System.Windows.Forms.Panel();
            this.btnActionDoubleLeftClick = new System.Windows.Forms.Button();
            this.panelSaveAndCancel.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlPageKeyboard.SuspendLayout();
            this.pnlRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlFKeyHighlight3.SuspendLayout();
            this.pnlFKeyHighlight4.SuspendLayout();
            this.pnlDoubleClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlFKeyHighlight5.SuspendLayout();
            this.pnlFKeyHighlight6.SuspendLayout();
            this.pnlScroll.SuspendLayout();
            this.pnlFKeyHighlight8.SuspendLayout();
            this.pnlFKeyHighlight7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlLeftClick.SuspendLayout();
            this.pnlFKeyHighlight2.SuspendLayout();
            this.pnlFKeyHighlight1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFKeyHighlight10.SuspendLayout();
            this.pnlFKeyHighlight9.SuspendLayout();
            this.pnlGeneralButton.SuspendLayout();
            this.pnlKeysButton.SuspendLayout();
            this.pnlSwitchSetting.SuspendLayout();
            this.pnlRearrangeButton.SuspendLayout();
            this.pnlZoomButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlZoomSize.SuspendLayout();
            this.pnlZoomSizeContent.SuspendLayout();
            this.pnlZWSPlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoomWindowSize)).BeginInit();
            this.pnlZWSMinus.SuspendLayout();
            this.pnlZoomAmount.SuspendLayout();
            this.pnlZoomAmountContent.SuspendLayout();
            this.pnlZIAPlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoomAmount)).BeginInit();
            this.pnlZIAMinus.SuspendLayout();
            this.pnlZoomSettings.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.pnlFixationTimeOut.SuspendLayout();
            this.pnlFixTimeOutContent.SuspendLayout();
            this.pnlFTOPlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFixTimeOut)).BeginInit();
            this.pnlFTOMins.SuspendLayout();
            this.panelOther.SuspendLayout();
            this.pnlOtherAuto.SuspendLayout();
            this.pnlAuto.SuspendLayout();
            this.panelPrecision.SuspendLayout();
            this.pnlFixTimeLengthContent.SuspendLayout();
            this.pnlFTLPlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFixTimeLength)).BeginInit();
            this.pnlFTLMins.SuspendLayout();
            this.pnlRearrange.SuspendLayout();
            this.pnlRearrangeControls.SuspendLayout();
            this.pnlMoveUpButton.SuspendLayout();
            this.pnlMoveDownButton.SuspendLayout();
            this.pnlRemoveButton.SuspendLayout();
            this.pnlRightClickButton.SuspendLayout();
            this.pnlSettingsButton.SuspendLayout();
            this.pnlLeftClickButton.SuspendLayout();
            this.pnlKeyboardButton.SuspendLayout();
            this.pnlScrollClickButton.SuspendLayout();
            this.pnlDoubleLeftClickButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(2, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 40);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(2, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 40);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelSaveAndCancel
            // 
            this.panelSaveAndCancel.Controls.Add(this.pnlCancel);
            this.panelSaveAndCancel.Controls.Add(this.pnlSave);
            this.panelSaveAndCancel.Location = new System.Drawing.Point(309, 638);
            this.panelSaveAndCancel.Margin = new System.Windows.Forms.Padding(2);
            this.panelSaveAndCancel.Name = "panelSaveAndCancel";
            this.panelSaveAndCancel.Size = new System.Drawing.Size(364, 72);
            this.panelSaveAndCancel.TabIndex = 25;
            // 
            // pnlCancel
            // 
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.Location = new System.Drawing.Point(215, 17);
            this.pnlCancel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(135, 44);
            this.pnlCancel.TabIndex = 22;
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Location = new System.Drawing.Point(11, 17);
            this.pnlSave.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(135, 44);
            this.pnlSave.TabIndex = 22;
            // 
            // pnlPageKeyboard
            // 
            this.pnlPageKeyboard.BackColor = System.Drawing.Color.Black;
            this.pnlPageKeyboard.Controls.Add(this.lbFKeyFeedback);
            this.pnlPageKeyboard.Controls.Add(this.pnlRightClick);
            this.pnlPageKeyboard.Controls.Add(this.pnlDoubleClick);
            this.pnlPageKeyboard.Controls.Add(this.pnlScroll);
            this.pnlPageKeyboard.Controls.Add(this.pnlLeftClick);
            this.pnlPageKeyboard.Location = new System.Drawing.Point(643, 86);
            this.pnlPageKeyboard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPageKeyboard.Name = "pnlPageKeyboard";
            this.pnlPageKeyboard.Size = new System.Drawing.Size(154, 62);
            this.pnlPageKeyboard.TabIndex = 26;
            // 
            // lbFKeyFeedback
            // 
            this.lbFKeyFeedback.AutoSize = true;
            this.lbFKeyFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFKeyFeedback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFKeyFeedback.Location = new System.Drawing.Point(454, 365);
            this.lbFKeyFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFKeyFeedback.Name = "lbFKeyFeedback";
            this.lbFKeyFeedback.Size = new System.Drawing.Size(60, 24);
            this.lbFKeyFeedback.TabIndex = 5;
            this.lbFKeyFeedback.Text = "label7";
            // 
            // pnlRightClick
            // 
            this.pnlRightClick.Controls.Add(this.lbRight);
            this.pnlRightClick.Controls.Add(this.pictureBox2);
            this.pnlRightClick.Controls.Add(this.pnlFKeyHighlight3);
            this.pnlRightClick.Controls.Add(this.pnlFKeyHighlight4);
            this.pnlRightClick.Location = new System.Drawing.Point(241, 82);
            this.pnlRightClick.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRightClick.Name = "pnlRightClick";
            this.pnlRightClick.Size = new System.Drawing.Size(148, 254);
            this.pnlRightClick.TabIndex = 4;
            // 
            // lbRight
            // 
            this.lbRight.AutoSize = true;
            this.lbRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRight.Location = new System.Drawing.Point(13, 230);
            this.lbRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(60, 24);
            this.lbRight.TabIndex = 3;
            this.lbRight.Text = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GazeToolBar.Properties.Resources.Right_Click_icon;
            this.pictureBox2.Location = new System.Drawing.Point(13, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlFKeyHighlight3
            // 
            this.pnlFKeyHighlight3.Controls.Add(this.btFKeyRightClick);
            this.pnlFKeyHighlight3.Location = new System.Drawing.Point(13, 105);
            this.pnlFKeyHighlight3.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFKeyHighlight3.Name = "pnlFKeyHighlight3";
            this.pnlFKeyHighlight3.Size = new System.Drawing.Size(116, 51);
            this.pnlFKeyHighlight3.TabIndex = 6;
            // 
            // btFKeyRightClick
            // 
            this.btFKeyRightClick.FlatAppearance.BorderSize = 5;
            this.btFKeyRightClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFKeyRightClick.ForeColor = System.Drawing.Color.White;
            this.btFKeyRightClick.Location = new System.Drawing.Point(2, 3);
            this.btFKeyRightClick.Margin = new System.Windows.Forms.Padding(2);
            this.btFKeyRightClick.Name = "btFKeyRightClick";
            this.btFKeyRightClick.Size = new System.Drawing.Size(112, 46);
            this.btFKeyRightClick.TabIndex = 1;
            this.btFKeyRightClick.Text = "Set";
            this.btFKeyRightClick.UseVisualStyleBackColor = true;
            this.btFKeyRightClick.Click += new System.EventHandler(this.btFKeyRightClick_Click);
            // 
            // pnlFKeyHighlight4
            // 
            this.pnlFKeyHighlight4.Controls.Add(this.btClearFKeyRightClick);
            this.pnlFKeyHighlight4.Location = new System.Drawing.Point(13, 165);
            this.pnlFKeyHighlight4.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFKeyHighlight4.Name = "pnlFKeyHighlight4";
            this.pnlFKeyHighlight4.Size = new System.Drawing.Size(116, 51);
            this.pnlFKeyHighlight4.TabIndex = 7;
            // 
            // btClearFKeyRightClick
            // 
            this.btClearFKeyRightClick.FlatAppearance.BorderSize = 5;
            this.btClearFKeyRightClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearFKeyRightClick.ForeColor = System.Drawing.Color.White;
            this.btClearFKeyRightClick.Location = new System.Drawing.Point(2, 2);
            this.btClearFKeyRightClick.Margin = new System.Windows.Forms.Padding(2);
            this.btClearFKeyRightClick.Name = "btClearFKeyRightClick";
            this.btClearFKeyRightClick.Size = new System.Drawing.Size(112, 46);
            this.btClearFKeyRightClick.TabIndex = 2;
            this.btClearFKeyRightClick.Text = "Clear";
            this.btClearFKeyRightClick.UseVisualStyleBackColor = true;
            this.btClearFKeyRightClick.Click += new System.EventHandler(this.btClearFKeyRightClick_Click);
            // 
            // pnlDoubleClick
            // 
            this.pnlDoubleClick.Controls.Add(this.lbDouble);
            this.pnlDoubleClick.Controls.Add(this.pictureBox3);
            this.pnlDoubleClick.Controls.Add(this.pnlFKeyHighlight5);
            this.pnlDoubleClick.Controls.Add(this.pnlFKeyHighlight6);
            this.pnlDoubleClick.Location = new System.Drawing.Point(393, 82);
            this.pnlDoubleClick.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDoubleClick.Name = "pnlDoubleClick";
            this.pnlDoubleClick.Size = new System.Drawing.Size(148, 254);
            this.pnlDoubleClick.TabIndex = 4;
            // 
            // lbDouble
            // 
            this.lbDouble.AutoSize = true;
            this.lbDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDouble.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDouble.Location = new System.Drawing.Point(15, 230);
            this.lbDouble.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDouble.Name = "lbDouble";
            this.lbDouble.Size = new System.Drawing.Size(60, 24);
            this.lbDouble.TabIndex = 3;
            this.lbDouble.Text = "label4";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GazeToolBar.Properties.Resources.Double_Click_icon;
            this.pictureBox3.Location = new System.Drawing.Point(16, 22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnlFKeyHighlight5
            // 
            this.pnlFKeyHighlight5.Controls.Add(this.btFKeyDoubleClick);
            this.pnlFKeyHighlight5.Location = new System.Drawing.Point(16, 108);
            this.pnlFKeyHighlight5.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFKeyHighlight5.Name = "pnlFKeyHighlight5";
            this.pnlFKeyHighlight5.Size = new System.Drawing.Size(116, 51);
            this.pnlFKeyHighlight5.TabIndex = 8;
            // 
            // btFKeyDoubleClick
            // 
            this.btFKeyDoubleClick.FlatAppearance.BorderSize = 5;
            this.btFKeyDoubleClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFKeyDoubleClick.ForeColor = System.Drawing.Color.White;
            this.btFKeyDoubleClick.Location = new System.Drawing.Point(2, 2);
            this.btFKeyDoubleClick.Margin = new System.Windows.Forms.Padding(2);
            this.btFKeyDoubleClick.Name = "btFKeyDoubleClick";
            this.btFKeyDoubleClick.Size = new System.Drawing.Size(112, 46);
            this.btFKeyDoubleClick.TabIndex = 1;
            this.btFKeyDoubleClick.Text = "Set";
            this.btFKeyDoubleClick.UseVisualStyleBackColor = true;
            this.btFKeyDoubleClick.Click += new System.EventHandler(this.btFKeyDoubleClick_Click);
            // 
            // pnlFKeyHighlight6
            // 
            this.pnlFKeyHighlight6.Controls.Add(this.btClearFKeyDoubleClick);
            this.pnlFKeyHighlight6.Location = new System.Drawing.Point(16, 165);
            this.pnlFKeyHighlight6.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFKeyHighlight6.Name = "pnlFKeyHighlight6";
            this.pnlFKeyHighlight6.Size = new System.Drawing.Size(116, 51);
            this.pnlFKeyHighlight6.TabIndex = 9;
            // 
            // btClearFKeyDoubleClick
            // 
            this.btClearFKeyDoubleClick.FlatAppearance.BorderSize = 5;
            this.btClearFKeyDoubleClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearFKeyDoubleClick.ForeColor = System.Drawing.Color.White;
            this.btClearFKeyDoubleClick.Location = new System.Drawing.Point(2, 2);
            this.btClearFKeyDoubleClick.Margin = new System.Windows.Forms.Padding(2);
            this.btClearFKeyDoubleClick.Name = "btClearFKeyDoubleClick";
            this.btClearFKeyDoubleClick.Size = new System.Drawing.Size(112, 46);
            this.btClearFKeyDoubleClick.TabIndex = 2;
            this.btClearFKeyDoubleClick.Text = "Clear";
            this.btClearFKeyDoubleClick.UseVisualStyleBackColor = true;
            this.btClearFKeyDoubleClick.Click += new System.EventHandler(this.btClearFKeyDoubleClick_Click);
            // 
            // pnlScroll
            // 
            this.pnlScroll.Controls.Add(this.lbScroll);
            this.pnlScroll.Controls.Add(this.pnlFKeyHighlight8);
            this.pnlScroll.Controls.Add(this.pnlFKeyHighlight7);
            this.pnlScroll.Controls.Add(this.pictureBox4);
            this.pnlScroll.Location = new System.Drawing.Point(545, 82);
            this.pnlScroll.Margin = new System.Windows.Forms.Padding(2);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(148, 254);
            this.pnlScroll.TabIndex = 4;
            // 
            // lbScroll
            // 
            this.lbScroll.AutoSize = true;
            this.lbScroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScroll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbScroll.Location = new System.Drawing.Point(21, 230);
            this.lbScroll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbScroll.Name = "lbScroll";
            this.lbScroll.Size = new System.Drawing.Size(60, 24);
            this.lbScroll.TabIndex = 3;
            this.lbScroll.Text = "label5";
            // 
            // pnlFKeyHighlight8
            // 
            this.pnlFKeyHighlight8.Controls.Add(this.btClearFKeyScroll);
            this.pnlFKeyHighlight8.Location = new System.Drawing.Point(21, 165);
            this.pnlFKeyHighlight8.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFKeyHighlight8.Name = "pnlFKeyHighlight8";
            this.pnlFKeyHighlight8.Size = new System.Drawing.Size(116, 51);
            this.pnlFKeyHighlight8.TabIndex = 9;
            // 
            // btClearFKeyScroll
            // 
            this.btClearFKeyScroll.FlatAppearance.BorderSize = 5;
            this.btClearFKeyScroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearFKeyScroll.ForeColor = System.Drawing.Color.White;
            this.btClearFKeyScroll.Location = new System.Drawing.Point(2, 2);
            this.btClearFKeyScroll.Margin = new System.Windows.Forms.Padding(2);
            this.btClearFKeyScroll.Name = "btClearFKeyScroll";
            this.btClearFKeyScroll.Size = new System.Drawing.Size(112, 46);
            this.btClearFKeyScroll.TabIndex = 2;
            this.btClearFKeyScroll.Text = "Clear";
            this.btClearFKeyScroll.UseVisualStyleBackColor = true;
            this.btClearFKeyScroll.Click += new System.EventHandler(this.btClearFKeyScroll_Click);
            // 
            // pnlFKeyHighlight7
            // 
            this.pnlFKeyHighlight7.Controls.Add(this.btFKeyScroll);
            this.pnlFKeyHighlight7.Location = new System.Drawing.Point(19, 108);
            this.pnlFKeyHighlight7.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFKeyHighlight7.Name = "pnlFKeyHighlight7";
            this.pnlFKeyHighlight7.Size = new System.Drawing.Size(116, 51);
            this.pnlFKeyHighlight7.TabIndex = 8;
            // 
            // btFKeyScroll
            // 
            this.btFKeyScroll.FlatAppearance.BorderSize = 5;
            this.btFKeyScroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFKeyScroll.ForeColor = System.Drawing.Color.White;
            this.btFKeyScroll.Location = new System.Drawing.Point(2, 2);
            this.btFKeyScroll.Margin = new System.Windows.Forms.Padding(2);
            this.btFKeyScroll.Name = "btFKeyScroll";
            this.btFKeyScroll.Size = new System.Drawing.Size(112, 46);
            this.btFKeyScroll.TabIndex = 1;
            this.btFKeyScroll.Text = "Set";
            this.btFKeyScroll.UseVisualStyleBackColor = true;
            this.btFKeyScroll.Click += new System.EventHandler(this.btFKeyScroll_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GazeToolBar.Properties.Resources.Scroll_icon;
            this.pictureBox4.Location = new System.Drawing.Point(19, 22);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(114, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pnlLeftClick
            // 
            this.pnlLeftClick.Controls.Add(this.pnlFKeyHighlight2);
            this.pnlLeftClick.Controls.Add(this.pnlFKeyHighlight1);
            this.pnlLeftClick.Controls.Add(this.lbLeft);
            this.pnlLeftClick.Controls.Add(this.pictureBox1);
            this.pnlLeftClick.Location = new System.Drawing.Point(87, 82);
            this.pnlLeftClick.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeftClick.Name = "pnlLeftClick";
            this.pnlLeftClick.Size = new System.Drawing.Size(148, 254);
            this.pnlLeftClick.TabIndex = 0;
            // 
            // pnlFKeyHighlight2
            // 
            this.pnlFKeyHighlight2.Controls.Add(this.btClearFKeyLeftClick);
            this.pnlFKeyHighlight2.Location = new System.Drawing.Point(18, 165);
            this.pnlFKeyHighlight2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFKeyHighlight2.Name = "pnlFKeyHighlight2";
            this.pnlFKeyHighlight2.Size = new System.Drawing.Size(116, 51);
            this.pnlFKeyHighlight2.TabIndex = 5;
            // 
            // btClearFKeyLeftClick
            // 
            this.btClearFKeyLeftClick.FlatAppearance.BorderSize = 5;
            this.btClearFKeyLeftClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearFKeyLeftClick.ForeColor = System.Drawing.Color.White;
            this.btClearFKeyLeftClick.Location = new System.Drawing.Point(1, 3);
            this.btClearFKeyLeftClick.Margin = new System.Windows.Forms.Padding(2);
            this.btClearFKeyLeftClick.Name = "btClearFKeyLeftClick";
            this.btClearFKeyLeftClick.Size = new System.Drawing.Size(112, 46);
            this.btClearFKeyLeftClick.TabIndex = 2;
            this.btClearFKeyLeftClick.Text = "Clear";
            this.btClearFKeyLeftClick.UseVisualStyleBackColor = true;
            this.btClearFKeyLeftClick.Click += new System.EventHandler(this.btClearFKeyLeftClick_Click);
            // 
            // pnlFKeyHighlight1
            // 
            this.pnlFKeyHighlight1.Controls.Add(this.btFKeyLeftClick);
            this.pnlFKeyHighlight1.Location = new System.Drawing.Point(16, 105);
            this.pnlFKeyHighlight1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFKeyHighlight1.Name = "pnlFKeyHighlight1";
            this.pnlFKeyHighlight1.Size = new System.Drawing.Size(116, 51);
            this.pnlFKeyHighlight1.TabIndex = 4;
            // 
            // btFKeyLeftClick
            // 
            this.btFKeyLeftClick.FlatAppearance.BorderSize = 5;
            this.btFKeyLeftClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFKeyLeftClick.ForeColor = System.Drawing.Color.White;
            this.btFKeyLeftClick.Location = new System.Drawing.Point(2, 3);
            this.btFKeyLeftClick.Margin = new System.Windows.Forms.Padding(2);
            this.btFKeyLeftClick.Name = "btFKeyLeftClick";
            this.btFKeyLeftClick.Size = new System.Drawing.Size(112, 46);
            this.btFKeyLeftClick.TabIndex = 1;
            this.btFKeyLeftClick.Text = "Set";
            this.btFKeyLeftClick.UseVisualStyleBackColor = true;
            this.btFKeyLeftClick.Click += new System.EventHandler(this.btFKeyLeftClick_Click);
            // 
            // lbLeft
            // 
            this.lbLeft.AutoSize = true;
            this.lbLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLeft.Location = new System.Drawing.Point(17, 230);
            this.lbLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(60, 24);
            this.lbLeft.TabIndex = 3;
            this.lbLeft.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GazeToolBar.Properties.Resources.Left_Click_icon;
            this.pictureBox1.Location = new System.Drawing.Point(16, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlFKeyHighlight10
            // 
            this.pnlFKeyHighlight10.Controls.Add(this.btClearFKeyDrapAndDrop);
            this.pnlFKeyHighlight10.Location = new System.Drawing.Point(21, 165);
            this.pnlFKeyHighlight10.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFKeyHighlight10.Name = "pnlFKeyHighlight10";
            this.pnlFKeyHighlight10.Size = new System.Drawing.Size(116, 51);
            this.pnlFKeyHighlight10.TabIndex = 9;
            // 
            // btClearFKeyDrapAndDrop
            // 
            this.btClearFKeyDrapAndDrop.FlatAppearance.BorderSize = 5;
            this.btClearFKeyDrapAndDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearFKeyDrapAndDrop.ForeColor = System.Drawing.Color.White;
            this.btClearFKeyDrapAndDrop.Location = new System.Drawing.Point(2, 3);
            this.btClearFKeyDrapAndDrop.Margin = new System.Windows.Forms.Padding(2);
            this.btClearFKeyDrapAndDrop.Name = "btClearFKeyDrapAndDrop";
            this.btClearFKeyDrapAndDrop.Size = new System.Drawing.Size(112, 45);
            this.btClearFKeyDrapAndDrop.TabIndex = 2;
            this.btClearFKeyDrapAndDrop.Text = "Clear";
            this.btClearFKeyDrapAndDrop.UseVisualStyleBackColor = true;
            // 
            // pnlFKeyHighlight9
            // 
            this.pnlFKeyHighlight9.Controls.Add(this.btFKeyDrapAndDrop);
            this.pnlFKeyHighlight9.Location = new System.Drawing.Point(19, 108);
            this.pnlFKeyHighlight9.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFKeyHighlight9.Name = "pnlFKeyHighlight9";
            this.pnlFKeyHighlight9.Size = new System.Drawing.Size(116, 51);
            this.pnlFKeyHighlight9.TabIndex = 8;
            // 
            // btFKeyDrapAndDrop
            // 
            this.btFKeyDrapAndDrop.FlatAppearance.BorderSize = 5;
            this.btFKeyDrapAndDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFKeyDrapAndDrop.ForeColor = System.Drawing.Color.White;
            this.btFKeyDrapAndDrop.Location = new System.Drawing.Point(2, 2);
            this.btFKeyDrapAndDrop.Margin = new System.Windows.Forms.Padding(2);
            this.btFKeyDrapAndDrop.Name = "btFKeyDrapAndDrop";
            this.btFKeyDrapAndDrop.Size = new System.Drawing.Size(112, 45);
            this.btFKeyDrapAndDrop.TabIndex = 1;
            this.btFKeyDrapAndDrop.Text = "Set";
            this.btFKeyDrapAndDrop.UseVisualStyleBackColor = true;
            // 
            // btnGeneralSetting
            // 
            this.btnGeneralSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnGeneralSetting.FlatAppearance.BorderSize = 5;
            this.btnGeneralSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneralSetting.ForeColor = System.Drawing.Color.White;
            this.btnGeneralSetting.Location = new System.Drawing.Point(2, 2);
            this.btnGeneralSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeneralSetting.Name = "btnGeneralSetting";
            this.btnGeneralSetting.Size = new System.Drawing.Size(150, 70);
            this.btnGeneralSetting.TabIndex = 28;
            this.btnGeneralSetting.Text = "General Setting";
            this.btnGeneralSetting.UseVisualStyleBackColor = false;
            this.btnGeneralSetting.Click += new System.EventHandler(this.btnGeneralSetting_Click);
            // 
            // btnShortCutKeySetting
            // 
            this.btnShortCutKeySetting.BackColor = System.Drawing.Color.Transparent;
            this.btnShortCutKeySetting.FlatAppearance.BorderSize = 5;
            this.btnShortCutKeySetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortCutKeySetting.ForeColor = System.Drawing.Color.White;
            this.btnShortCutKeySetting.Location = new System.Drawing.Point(2, 2);
            this.btnShortCutKeySetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnShortCutKeySetting.Name = "btnShortCutKeySetting";
            this.btnShortCutKeySetting.Size = new System.Drawing.Size(150, 70);
            this.btnShortCutKeySetting.TabIndex = 29;
            this.btnShortCutKeySetting.Text = "Shortcut Keys";
            this.btnShortCutKeySetting.UseVisualStyleBackColor = false;
            this.btnShortCutKeySetting.Click += new System.EventHandler(this.btnKeyBoardSetting_Click);
            // 
            // pnlGeneralButton
            // 
            this.pnlGeneralButton.Controls.Add(this.btnGeneralSetting);
            this.pnlGeneralButton.Location = new System.Drawing.Point(2, 2);
            this.pnlGeneralButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGeneralButton.Name = "pnlGeneralButton";
            this.pnlGeneralButton.Size = new System.Drawing.Size(154, 75);
            this.pnlGeneralButton.TabIndex = 22;
            // 
            // pnlKeysButton
            // 
            this.pnlKeysButton.Controls.Add(this.btnShortCutKeySetting);
            this.pnlKeysButton.Location = new System.Drawing.Point(370, 2);
            this.pnlKeysButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnlKeysButton.Name = "pnlKeysButton";
            this.pnlKeysButton.Size = new System.Drawing.Size(154, 75);
            this.pnlKeysButton.TabIndex = 22;
            // 
            // pnlSwitchSetting
            // 
            this.pnlSwitchSetting.BackColor = System.Drawing.Color.Black;
            this.pnlSwitchSetting.Controls.Add(this.pnlRearrangeButton);
            this.pnlSwitchSetting.Controls.Add(this.pnlZoomButton);
            this.pnlSwitchSetting.Controls.Add(this.pnlKeysButton);
            this.pnlSwitchSetting.Controls.Add(this.pnlGeneralButton);
            this.pnlSwitchSetting.Location = new System.Drawing.Point(273, 0);
            this.pnlSwitchSetting.Name = "pnlSwitchSetting";
            this.pnlSwitchSetting.Size = new System.Drawing.Size(708, 81);
            this.pnlSwitchSetting.TabIndex = 28;
            // 
            // pnlRearrangeButton
            // 
            this.pnlRearrangeButton.Controls.Add(this.btnRearrangeSetting);
            this.pnlRearrangeButton.Location = new System.Drawing.Point(551, 2);
            this.pnlRearrangeButton.Name = "pnlRearrangeButton";
            this.pnlRearrangeButton.Size = new System.Drawing.Size(154, 75);
            this.pnlRearrangeButton.TabIndex = 32;
            // 
            // btnRearrangeSetting
            // 
            this.btnRearrangeSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnRearrangeSetting.FlatAppearance.BorderSize = 5;
            this.btnRearrangeSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRearrangeSetting.ForeColor = System.Drawing.Color.White;
            this.btnRearrangeSetting.Location = new System.Drawing.Point(2, 2);
            this.btnRearrangeSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnRearrangeSetting.Name = "btnRearrangeSetting";
            this.btnRearrangeSetting.Size = new System.Drawing.Size(150, 70);
            this.btnRearrangeSetting.TabIndex = 30;
            this.btnRearrangeSetting.Text = "Rearrange ToolBar";
            this.btnRearrangeSetting.UseVisualStyleBackColor = false;
            this.btnRearrangeSetting.Click += new System.EventHandler(this.btnRearrangeSetting_Click);
            // 
            // pnlZoomButton
            // 
            this.pnlZoomButton.Controls.Add(this.btnZoomSettings);
            this.pnlZoomButton.Location = new System.Drawing.Point(185, 2);
            this.pnlZoomButton.Name = "pnlZoomButton";
            this.pnlZoomButton.Size = new System.Drawing.Size(154, 75);
            this.pnlZoomButton.TabIndex = 31;
            // 
            // btnZoomSettings
            // 
            this.btnZoomSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomSettings.FlatAppearance.BorderSize = 5;
            this.btnZoomSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomSettings.ForeColor = System.Drawing.Color.White;
            this.btnZoomSettings.Location = new System.Drawing.Point(2, 2);
            this.btnZoomSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnZoomSettings.Name = "btnZoomSettings";
            this.btnZoomSettings.Size = new System.Drawing.Size(150, 70);
            this.btnZoomSettings.TabIndex = 30;
            this.btnZoomSettings.Text = "Zoom Settings";
            this.btnZoomSettings.UseVisualStyleBackColor = false;
            this.btnZoomSettings.Click += new System.EventHandler(this.btnZoomSettings_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(19, 22);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(114, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pnlZoomSize
            // 
            this.pnlZoomSize.BackColor = System.Drawing.Color.Black;
            this.pnlZoomSize.Controls.Add(this.pnlZoomSizeContent);
            this.pnlZoomSize.Controls.Add(this.labZoomWindowSize);
            this.pnlZoomSize.Location = new System.Drawing.Point(12, 108);
            this.pnlZoomSize.Name = "pnlZoomSize";
            this.pnlZoomSize.Size = new System.Drawing.Size(1156, 138);
            this.pnlZoomSize.TabIndex = 14;
            // 
            // pnlZoomSizeContent
            // 
            this.pnlZoomSizeContent.BackColor = System.Drawing.Color.Black;
            this.pnlZoomSizeContent.Controls.Add(this.pnlZWSPlus);
            this.pnlZoomSizeContent.Controls.Add(this.trackBarZoomWindowSize);
            this.pnlZoomSizeContent.Controls.Add(this.pnlZWSMinus);
            this.pnlZoomSizeContent.Location = new System.Drawing.Point(4, 22);
            this.pnlZoomSizeContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlZoomSizeContent.Name = "pnlZoomSizeContent";
            this.pnlZoomSizeContent.Size = new System.Drawing.Size(1125, 110);
            this.pnlZoomSizeContent.TabIndex = 22;
            // 
            // pnlZWSPlus
            // 
            this.pnlZWSPlus.Controls.Add(this.btnZoomSizePlus);
            this.pnlZWSPlus.Location = new System.Drawing.Point(1014, 9);
            this.pnlZWSPlus.Margin = new System.Windows.Forms.Padding(2);
            this.pnlZWSPlus.Name = "pnlZWSPlus";
            this.pnlZWSPlus.Size = new System.Drawing.Size(94, 95);
            this.pnlZWSPlus.TabIndex = 23;
            // 
            // btnZoomSizePlus
            // 
            this.btnZoomSizePlus.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomSizePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomSizePlus.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZoomSizePlus.ForeColor = System.Drawing.Color.White;
            this.btnZoomSizePlus.Location = new System.Drawing.Point(2, 2);
            this.btnZoomSizePlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnZoomSizePlus.Name = "btnZoomSizePlus";
            this.btnZoomSizePlus.Size = new System.Drawing.Size(90, 90);
            this.btnZoomSizePlus.TabIndex = 13;
            this.btnZoomSizePlus.Text = "+";
            this.btnZoomSizePlus.UseVisualStyleBackColor = false;
            this.btnZoomSizePlus.Click += new System.EventHandler(this.btnZoomSizePlus_Click);
            // 
            // trackBarZoomWindowSize
            // 
            this.trackBarZoomWindowSize.BackColor = System.Drawing.Color.Black;
            this.trackBarZoomWindowSize.Location = new System.Drawing.Point(108, 35);
            this.trackBarZoomWindowSize.Name = "trackBarZoomWindowSize";
            this.trackBarZoomWindowSize.Size = new System.Drawing.Size(896, 45);
            this.trackBarZoomWindowSize.TabIndex = 12;
            this.trackBarZoomWindowSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarZoomWindowSize.Value = 5;
            this.trackBarZoomWindowSize.ValueChanged += new System.EventHandler(this.trackBarZoomWindowSize_ValueChanged);
            // 
            // pnlZWSMinus
            // 
            this.pnlZWSMinus.Controls.Add(this.btnZoomSizeMinus);
            this.pnlZWSMinus.Location = new System.Drawing.Point(2, 9);
            this.pnlZWSMinus.Margin = new System.Windows.Forms.Padding(2);
            this.pnlZWSMinus.Name = "pnlZWSMinus";
            this.pnlZWSMinus.Size = new System.Drawing.Size(94, 95);
            this.pnlZWSMinus.TabIndex = 22;
            // 
            // btnZoomSizeMinus
            // 
            this.btnZoomSizeMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomSizeMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomSizeMinus.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZoomSizeMinus.ForeColor = System.Drawing.Color.White;
            this.btnZoomSizeMinus.Location = new System.Drawing.Point(2, 2);
            this.btnZoomSizeMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnZoomSizeMinus.Name = "btnZoomSizeMinus";
            this.btnZoomSizeMinus.Size = new System.Drawing.Size(90, 90);
            this.btnZoomSizeMinus.TabIndex = 14;
            this.btnZoomSizeMinus.Text = "-";
            this.btnZoomSizeMinus.UseVisualStyleBackColor = false;
            this.btnZoomSizeMinus.Click += new System.EventHandler(this.btnZoomSizeMinus_Click);
            // 
            // labZoomWindowSize
            // 
            this.labZoomWindowSize.AutoSize = true;
            this.labZoomWindowSize.Font = new System.Drawing.Font("SimSun", 12F);
            this.labZoomWindowSize.ForeColor = System.Drawing.Color.White;
            this.labZoomWindowSize.Location = new System.Drawing.Point(15, 0);
            this.labZoomWindowSize.Name = "labZoomWindowSize";
            this.labZoomWindowSize.Size = new System.Drawing.Size(136, 16);
            this.labZoomWindowSize.TabIndex = 11;
            this.labZoomWindowSize.Text = "Zoom Window Size";
            // 
            // pnlZoomAmount
            // 
            this.pnlZoomAmount.BackColor = System.Drawing.Color.Black;
            this.pnlZoomAmount.Controls.Add(this.pnlZoomAmountContent);
            this.pnlZoomAmount.Controls.Add(this.labZoomAmount);
            this.pnlZoomAmount.Location = new System.Drawing.Point(12, 259);
            this.pnlZoomAmount.Name = "pnlZoomAmount";
            this.pnlZoomAmount.Size = new System.Drawing.Size(1156, 138);
            this.pnlZoomAmount.TabIndex = 23;
            // 
            // pnlZoomAmountContent
            // 
            this.pnlZoomAmountContent.BackColor = System.Drawing.Color.Black;
            this.pnlZoomAmountContent.Controls.Add(this.pnlZIAPlus);
            this.pnlZoomAmountContent.Controls.Add(this.trackBarZoomAmount);
            this.pnlZoomAmountContent.Controls.Add(this.pnlZIAMinus);
            this.pnlZoomAmountContent.Location = new System.Drawing.Point(8, 20);
            this.pnlZoomAmountContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlZoomAmountContent.Name = "pnlZoomAmountContent";
            this.pnlZoomAmountContent.Size = new System.Drawing.Size(1121, 110);
            this.pnlZoomAmountContent.TabIndex = 22;
            // 
            // pnlZIAPlus
            // 
            this.pnlZIAPlus.Controls.Add(this.btnZoomAmountPlus);
            this.pnlZIAPlus.Location = new System.Drawing.Point(1014, 9);
            this.pnlZIAPlus.Margin = new System.Windows.Forms.Padding(2);
            this.pnlZIAPlus.Name = "pnlZIAPlus";
            this.pnlZIAPlus.Size = new System.Drawing.Size(94, 95);
            this.pnlZIAPlus.TabIndex = 23;
            // 
            // btnZoomAmountPlus
            // 
            this.btnZoomAmountPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomAmountPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomAmountPlus.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZoomAmountPlus.ForeColor = System.Drawing.Color.White;
            this.btnZoomAmountPlus.Location = new System.Drawing.Point(2, 2);
            this.btnZoomAmountPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnZoomAmountPlus.Name = "btnZoomAmountPlus";
            this.btnZoomAmountPlus.Size = new System.Drawing.Size(90, 90);
            this.btnZoomAmountPlus.TabIndex = 16;
            this.btnZoomAmountPlus.Text = "+";
            this.btnZoomAmountPlus.UseVisualStyleBackColor = false;
            this.btnZoomAmountPlus.Click += new System.EventHandler(this.btnZoomAmountPlus_Click);
            // 
            // trackBarZoomAmount
            // 
            this.trackBarZoomAmount.AutoSize = false;
            this.trackBarZoomAmount.Location = new System.Drawing.Point(108, 35);
            this.trackBarZoomAmount.Name = "trackBarZoomAmount";
            this.trackBarZoomAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarZoomAmount.Size = new System.Drawing.Size(896, 45);
            this.trackBarZoomAmount.TabIndex = 15;
            this.trackBarZoomAmount.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarZoomAmount.Value = 5;
            this.trackBarZoomAmount.ValueChanged += new System.EventHandler(this.trackBarZoomAmount_ValueChanged);
            // 
            // pnlZIAMinus
            // 
            this.pnlZIAMinus.Controls.Add(this.btnZoomAmountMinus);
            this.pnlZIAMinus.Location = new System.Drawing.Point(2, 9);
            this.pnlZIAMinus.Margin = new System.Windows.Forms.Padding(2);
            this.pnlZIAMinus.Name = "pnlZIAMinus";
            this.pnlZIAMinus.Size = new System.Drawing.Size(94, 95);
            this.pnlZIAMinus.TabIndex = 22;
            // 
            // btnZoomAmountMinus
            // 
            this.btnZoomAmountMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomAmountMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomAmountMinus.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZoomAmountMinus.ForeColor = System.Drawing.Color.White;
            this.btnZoomAmountMinus.Location = new System.Drawing.Point(2, 2);
            this.btnZoomAmountMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnZoomAmountMinus.Name = "btnZoomAmountMinus";
            this.btnZoomAmountMinus.Size = new System.Drawing.Size(90, 90);
            this.btnZoomAmountMinus.TabIndex = 17;
            this.btnZoomAmountMinus.Text = "-";
            this.btnZoomAmountMinus.UseVisualStyleBackColor = false;
            this.btnZoomAmountMinus.Click += new System.EventHandler(this.btnZoomAmountMinus_Click);
            // 
            // labZoomAmount
            // 
            this.labZoomAmount.AutoSize = true;
            this.labZoomAmount.Font = new System.Drawing.Font("SimSun", 12F);
            this.labZoomAmount.ForeColor = System.Drawing.Color.White;
            this.labZoomAmount.Location = new System.Drawing.Point(34, 0);
            this.labZoomAmount.Name = "labZoomAmount";
            this.labZoomAmount.Size = new System.Drawing.Size(120, 16);
            this.labZoomAmount.TabIndex = 14;
            this.labZoomAmount.Text = "Zoom In Amount";
            // 
            // pnlZoomSettings
            // 
            this.pnlZoomSettings.Controls.Add(this.pnlZoomAmount);
            this.pnlZoomSettings.Controls.Add(this.pnlZoomSize);
            this.pnlZoomSettings.Location = new System.Drawing.Point(460, 87);
            this.pnlZoomSettings.Margin = new System.Windows.Forms.Padding(2);
            this.pnlZoomSettings.Name = "pnlZoomSettings";
            this.pnlZoomSettings.Size = new System.Drawing.Size(152, 61);
            this.pnlZoomSettings.TabIndex = 29;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.Color.Black;
            this.pnlGeneral.Controls.Add(this.pnlFixationTimeOut);
            this.pnlGeneral.Controls.Add(this.panelOther);
            this.pnlGeneral.Controls.Add(this.panelPrecision);
            this.pnlGeneral.Location = new System.Drawing.Point(277, 92);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(150, 56);
            this.pnlGeneral.TabIndex = 27;
            // 
            // pnlFixationTimeOut
            // 
            this.pnlFixationTimeOut.BackColor = System.Drawing.Color.Black;
            this.pnlFixationTimeOut.Controls.Add(this.pnlFixTimeOutContent);
            this.pnlFixationTimeOut.Controls.Add(this.lblSpeed);
            this.pnlFixationTimeOut.Location = new System.Drawing.Point(0, 258);
            this.pnlFixationTimeOut.Name = "pnlFixationTimeOut";
            this.pnlFixationTimeOut.Size = new System.Drawing.Size(1258, 143);
            this.pnlFixationTimeOut.TabIndex = 16;
            // 
            // pnlFixTimeOutContent
            // 
            this.pnlFixTimeOutContent.BackColor = System.Drawing.Color.Black;
            this.pnlFixTimeOutContent.Controls.Add(this.pnlFTOPlus);
            this.pnlFixTimeOutContent.Controls.Add(this.trackBarFixTimeOut);
            this.pnlFixTimeOutContent.Controls.Add(this.pnlFTOMins);
            this.pnlFixTimeOutContent.Location = new System.Drawing.Point(119, 18);
            this.pnlFixTimeOutContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFixTimeOutContent.Name = "pnlFixTimeOutContent";
            this.pnlFixTimeOutContent.Size = new System.Drawing.Size(1125, 113);
            this.pnlFixTimeOutContent.TabIndex = 22;
            // 
            // pnlFTOPlus
            // 
            this.pnlFTOPlus.Controls.Add(this.btnFixTimeOutPlus);
            this.pnlFTOPlus.Location = new System.Drawing.Point(1014, 9);
            this.pnlFTOPlus.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFTOPlus.Name = "pnlFTOPlus";
            this.pnlFTOPlus.Size = new System.Drawing.Size(94, 95);
            this.pnlFTOPlus.TabIndex = 23;
            // 
            // btnFixTimeOutPlus
            // 
            this.btnFixTimeOutPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnFixTimeOutPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixTimeOutPlus.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFixTimeOutPlus.ForeColor = System.Drawing.Color.White;
            this.btnFixTimeOutPlus.Location = new System.Drawing.Point(2, 2);
            this.btnFixTimeOutPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnFixTimeOutPlus.Name = "btnFixTimeOutPlus";
            this.btnFixTimeOutPlus.Size = new System.Drawing.Size(90, 90);
            this.btnFixTimeOutPlus.TabIndex = 16;
            this.btnFixTimeOutPlus.Text = "+";
            this.btnFixTimeOutPlus.UseVisualStyleBackColor = false;
            this.btnFixTimeOutPlus.Click += new System.EventHandler(this.btnFixTimeOutPlus_Click);
            // 
            // trackBarFixTimeOut
            // 
            this.trackBarFixTimeOut.Location = new System.Drawing.Point(108, 35);
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
            this.pnlFTOMins.Location = new System.Drawing.Point(2, 9);
            this.pnlFTOMins.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFTOMins.Name = "pnlFTOMins";
            this.pnlFTOMins.Size = new System.Drawing.Size(94, 95);
            this.pnlFTOMins.TabIndex = 22;
            // 
            // btnFixTimeOutMins
            // 
            this.btnFixTimeOutMins.BackColor = System.Drawing.Color.Transparent;
            this.btnFixTimeOutMins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixTimeOutMins.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFixTimeOutMins.ForeColor = System.Drawing.Color.White;
            this.btnFixTimeOutMins.Location = new System.Drawing.Point(2, 2);
            this.btnFixTimeOutMins.Margin = new System.Windows.Forms.Padding(2);
            this.btnFixTimeOutMins.Name = "btnFixTimeOutMins";
            this.btnFixTimeOutMins.Size = new System.Drawing.Size(90, 90);
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
            // panelOther
            // 
            this.panelOther.BackColor = System.Drawing.Color.Black;
            this.panelOther.Controls.Add(this.pnlOtherAuto);
            this.panelOther.Controls.Add(this.lblOther);
            this.panelOther.Location = new System.Drawing.Point(0, 440);
            this.panelOther.Name = "panelOther";
            this.panelOther.Size = new System.Drawing.Size(1243, 192);
            this.panelOther.TabIndex = 21;
            // 
            // pnlOtherAuto
            // 
            this.pnlOtherAuto.BackColor = System.Drawing.Color.Black;
            this.pnlOtherAuto.Controls.Add(this.pnlAuto);
            this.pnlOtherAuto.Controls.Add(this.label2);
            this.pnlOtherAuto.Location = new System.Drawing.Point(765, 9);
            this.pnlOtherAuto.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOtherAuto.Name = "pnlOtherAuto";
            this.pnlOtherAuto.Size = new System.Drawing.Size(204, 178);
            this.pnlOtherAuto.TabIndex = 22;
            // 
            // pnlAuto
            // 
            this.pnlAuto.Controls.Add(this.btnAutoStart);
            this.pnlAuto.Location = new System.Drawing.Point(31, 69);
            this.pnlAuto.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAuto.Name = "pnlAuto";
            this.pnlAuto.Size = new System.Drawing.Size(59, 59);
            this.pnlAuto.TabIndex = 23;
            // 
            // btnAutoStart
            // 
            this.btnAutoStart.BackColor = System.Drawing.Color.Black;
            this.btnAutoStart.FlatAppearance.BorderSize = 5;
            this.btnAutoStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoStart.ForeColor = System.Drawing.Color.White;
            this.btnAutoStart.Location = new System.Drawing.Point(2, 2);
            this.btnAutoStart.Name = "btnAutoStart";
            this.btnAutoStart.Size = new System.Drawing.Size(55, 55);
            this.btnAutoStart.TabIndex = 4;
            this.btnAutoStart.UseVisualStyleBackColor = false;
            this.btnAutoStart.Click += new System.EventHandler(this.btnAutoStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Auto start";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblOther.ForeColor = System.Drawing.Color.White;
            this.lblOther.Location = new System.Drawing.Point(19, 78);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(48, 16);
            this.lblOther.TabIndex = 17;
            this.lblOther.Text = "Other";
            // 
            // panelPrecision
            // 
            this.panelPrecision.BackColor = System.Drawing.Color.Black;
            this.panelPrecision.Controls.Add(this.pnlFixTimeLengthContent);
            this.panelPrecision.Controls.Add(this.lblFixationDetectionTimeLength);
            this.panelPrecision.Location = new System.Drawing.Point(4, 56);
            this.panelPrecision.Name = "panelPrecision";
            this.panelPrecision.Size = new System.Drawing.Size(1254, 138);
            this.panelPrecision.TabIndex = 13;
            // 
            // pnlFixTimeLengthContent
            // 
            this.pnlFixTimeLengthContent.BackColor = System.Drawing.Color.Black;
            this.pnlFixTimeLengthContent.Controls.Add(this.pnlFTLPlus);
            this.pnlFixTimeLengthContent.Controls.Add(this.trackBarFixTimeLength);
            this.pnlFixTimeLengthContent.Controls.Add(this.pnlFTLMins);
            this.pnlFixTimeLengthContent.Location = new System.Drawing.Point(115, 18);
            this.pnlFixTimeLengthContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFixTimeLengthContent.Name = "pnlFixTimeLengthContent";
            this.pnlFixTimeLengthContent.Size = new System.Drawing.Size(1125, 110);
            this.pnlFixTimeLengthContent.TabIndex = 22;
            // 
            // pnlFTLPlus
            // 
            this.pnlFTLPlus.Controls.Add(this.btnFixTimeLengthPlus);
            this.pnlFTLPlus.Location = new System.Drawing.Point(1014, 9);
            this.pnlFTLPlus.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFTLPlus.Name = "pnlFTLPlus";
            this.pnlFTLPlus.Size = new System.Drawing.Size(94, 95);
            this.pnlFTLPlus.TabIndex = 23;
            // 
            // btnFixTimeLengthPlus
            // 
            this.btnFixTimeLengthPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnFixTimeLengthPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixTimeLengthPlus.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFixTimeLengthPlus.ForeColor = System.Drawing.Color.White;
            this.btnFixTimeLengthPlus.Location = new System.Drawing.Point(2, 2);
            this.btnFixTimeLengthPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnFixTimeLengthPlus.Name = "btnFixTimeLengthPlus";
            this.btnFixTimeLengthPlus.Size = new System.Drawing.Size(90, 90);
            this.btnFixTimeLengthPlus.TabIndex = 13;
            this.btnFixTimeLengthPlus.Text = "+";
            this.btnFixTimeLengthPlus.UseVisualStyleBackColor = false;
            this.btnFixTimeLengthPlus.Click += new System.EventHandler(this.btnFixTimeLengthPlus_Click);
            // 
            // trackBarFixTimeLength
            // 
            this.trackBarFixTimeLength.BackColor = System.Drawing.Color.Black;
            this.trackBarFixTimeLength.Location = new System.Drawing.Point(108, 35);
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
            this.pnlFTLMins.Size = new System.Drawing.Size(94, 95);
            this.pnlFTLMins.TabIndex = 22;
            // 
            // btnFixTimeLengthMins
            // 
            this.btnFixTimeLengthMins.BackColor = System.Drawing.Color.Transparent;
            this.btnFixTimeLengthMins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixTimeLengthMins.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFixTimeLengthMins.ForeColor = System.Drawing.Color.White;
            this.btnFixTimeLengthMins.Location = new System.Drawing.Point(2, 2);
            this.btnFixTimeLengthMins.Margin = new System.Windows.Forms.Padding(2);
            this.btnFixTimeLengthMins.Name = "btnFixTimeLengthMins";
            this.btnFixTimeLengthMins.Size = new System.Drawing.Size(90, 90);
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
            // pnlRearrange
            // 
            this.pnlRearrange.BackColor = System.Drawing.Color.Black;
            this.pnlRearrange.Controls.Add(this.pnlRearrangeControls);
            this.pnlRearrange.Controls.Add(this.pnlRightClickButton);
            this.pnlRearrange.Controls.Add(this.pnlSettingsButton);
            this.pnlRearrange.Controls.Add(this.pnlLeftClickButton);
            this.pnlRearrange.Controls.Add(this.pnlKeyboardButton);
            this.pnlRearrange.Controls.Add(this.pnlScrollClickButton);
            this.pnlRearrange.Controls.Add(this.pnlDoubleLeftClickButton);
            this.pnlRearrange.Location = new System.Drawing.Point(824, 87);
            this.pnlRearrange.Name = "pnlRearrange";
            this.pnlRearrange.Size = new System.Drawing.Size(157, 61);
            this.pnlRearrange.TabIndex = 30;
            // 
            // pnlRearrangeControls
            // 
            this.pnlRearrangeControls.Controls.Add(this.pnlMoveUpButton);
            this.pnlRearrangeControls.Controls.Add(this.pnlMoveDownButton);
            this.pnlRearrangeControls.Controls.Add(this.pnlRemoveButton);
            this.pnlRearrangeControls.Location = new System.Drawing.Point(636, 60);
            this.pnlRearrangeControls.Name = "pnlRearrangeControls";
            this.pnlRearrangeControls.Size = new System.Drawing.Size(132, 408);
            this.pnlRearrangeControls.TabIndex = 4;
            // 
            // pnlMoveUpButton
            // 
            this.pnlMoveUpButton.Controls.Add(this.btnMoveUp);
            this.pnlMoveUpButton.Location = new System.Drawing.Point(19, 19);
            this.pnlMoveUpButton.Name = "pnlMoveUpButton";
            this.pnlMoveUpButton.Size = new System.Drawing.Size(94, 95);
            this.pnlMoveUpButton.TabIndex = 3;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.Color.Black;
            this.btnMoveUp.Image = global::GazeToolBar.Properties.Resources.button_up;
            this.btnMoveUp.Location = new System.Drawing.Point(2, 2);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(90, 90);
            this.btnMoveUp.TabIndex = 0;
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // pnlMoveDownButton
            // 
            this.pnlMoveDownButton.Controls.Add(this.btnMoveDown);
            this.pnlMoveDownButton.Location = new System.Drawing.Point(19, 287);
            this.pnlMoveDownButton.Name = "pnlMoveDownButton";
            this.pnlMoveDownButton.Size = new System.Drawing.Size(94, 95);
            this.pnlMoveDownButton.TabIndex = 3;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.Color.Black;
            this.btnMoveDown.Image = global::GazeToolBar.Properties.Resources.button_down;
            this.btnMoveDown.Location = new System.Drawing.Point(2, 2);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(90, 90);
            this.btnMoveDown.TabIndex = 0;
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // pnlRemoveButton
            // 
            this.pnlRemoveButton.Controls.Add(this.btnRemove);
            this.pnlRemoveButton.Location = new System.Drawing.Point(19, 155);
            this.pnlRemoveButton.Name = "pnlRemoveButton";
            this.pnlRemoveButton.Size = new System.Drawing.Size(94, 95);
            this.pnlRemoveButton.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Black;
            this.btnRemove.Image = global::GazeToolBar.Properties.Resources.button_left;
            this.btnRemove.Location = new System.Drawing.Point(2, 2);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 90);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlRightClickButton
            // 
            this.pnlRightClickButton.BackColor = System.Drawing.Color.Black;
            this.pnlRightClickButton.Controls.Add(this.btnActionRightClick);
            this.pnlRightClickButton.Location = new System.Drawing.Point(179, 275);
            this.pnlRightClickButton.Name = "pnlRightClickButton";
            this.pnlRightClickButton.Size = new System.Drawing.Size(94, 95);
            this.pnlRightClickButton.TabIndex = 2;
            // 
            // btnActionRightClick
            // 
            this.btnActionRightClick.BackColor = System.Drawing.Color.Black;
            this.btnActionRightClick.Image = global::GazeToolBar.Properties.Resources.Right_Click_icon;
            this.btnActionRightClick.Location = new System.Drawing.Point(2, 2);
            this.btnActionRightClick.Margin = new System.Windows.Forms.Padding(2);
            this.btnActionRightClick.Name = "btnActionRightClick";
            this.btnActionRightClick.Size = new System.Drawing.Size(90, 90);
            this.btnActionRightClick.TabIndex = 0;
            this.btnActionRightClick.UseVisualStyleBackColor = false;
            this.btnActionRightClick.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // pnlSettingsButton
            // 
            this.pnlSettingsButton.Controls.Add(this.btnActionSettings);
            this.pnlSettingsButton.Location = new System.Drawing.Point(483, 167);
            this.pnlSettingsButton.Name = "pnlSettingsButton";
            this.pnlSettingsButton.Size = new System.Drawing.Size(94, 95);
            this.pnlSettingsButton.TabIndex = 2;
            // 
            // btnActionSettings
            // 
            this.btnActionSettings.BackColor = System.Drawing.Color.Black;
            this.btnActionSettings.Image = global::GazeToolBar.Properties.Resources.settings_icon;
            this.btnActionSettings.Location = new System.Drawing.Point(2, 2);
            this.btnActionSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnActionSettings.Name = "btnActionSettings";
            this.btnActionSettings.Size = new System.Drawing.Size(90, 90);
            this.btnActionSettings.TabIndex = 0;
            this.btnActionSettings.UseVisualStyleBackColor = false;
            this.btnActionSettings.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // pnlLeftClickButton
            // 
            this.pnlLeftClickButton.Controls.Add(this.btnActionLeftClick);
            this.pnlLeftClickButton.Location = new System.Drawing.Point(179, 167);
            this.pnlLeftClickButton.Name = "pnlLeftClickButton";
            this.pnlLeftClickButton.Size = new System.Drawing.Size(94, 95);
            this.pnlLeftClickButton.TabIndex = 2;
            // 
            // btnActionLeftClick
            // 
            this.btnActionLeftClick.BackColor = System.Drawing.Color.Black;
            this.btnActionLeftClick.Image = global::GazeToolBar.Properties.Resources.Left_Click_icon;
            this.btnActionLeftClick.Location = new System.Drawing.Point(2, 2);
            this.btnActionLeftClick.Margin = new System.Windows.Forms.Padding(2);
            this.btnActionLeftClick.Name = "btnActionLeftClick";
            this.btnActionLeftClick.Size = new System.Drawing.Size(90, 90);
            this.btnActionLeftClick.TabIndex = 0;
            this.btnActionLeftClick.UseVisualStyleBackColor = false;
            this.btnActionLeftClick.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // pnlKeyboardButton
            // 
            this.pnlKeyboardButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlKeyboardButton.Controls.Add(this.btnActionKeyboard);
            this.pnlKeyboardButton.Location = new System.Drawing.Point(290, 167);
            this.pnlKeyboardButton.Name = "pnlKeyboardButton";
            this.pnlKeyboardButton.Size = new System.Drawing.Size(94, 95);
            this.pnlKeyboardButton.TabIndex = 2;
            // 
            // btnActionKeyboard
            // 
            this.btnActionKeyboard.BackColor = System.Drawing.Color.Black;
            this.btnActionKeyboard.Image = global::GazeToolBar.Properties.Resources.Keyboard_icon;
            this.btnActionKeyboard.Location = new System.Drawing.Point(2, 2);
            this.btnActionKeyboard.Name = "btnActionKeyboard";
            this.btnActionKeyboard.Size = new System.Drawing.Size(90, 90);
            this.btnActionKeyboard.TabIndex = 0;
            this.btnActionKeyboard.UseVisualStyleBackColor = false;
            this.btnActionKeyboard.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // pnlScrollClickButton
            // 
            this.pnlScrollClickButton.Controls.Add(this.btnActionScrollClick);
            this.pnlScrollClickButton.Location = new System.Drawing.Point(290, 61);
            this.pnlScrollClickButton.Name = "pnlScrollClickButton";
            this.pnlScrollClickButton.Size = new System.Drawing.Size(94, 95);
            this.pnlScrollClickButton.TabIndex = 2;
            // 
            // btnActionScrollClick
            // 
            this.btnActionScrollClick.BackColor = System.Drawing.Color.Black;
            this.btnActionScrollClick.Image = global::GazeToolBar.Properties.Resources.Scroll_icon;
            this.btnActionScrollClick.Location = new System.Drawing.Point(2, 2);
            this.btnActionScrollClick.Name = "btnActionScrollClick";
            this.btnActionScrollClick.Size = new System.Drawing.Size(90, 90);
            this.btnActionScrollClick.TabIndex = 0;
            this.btnActionScrollClick.UseVisualStyleBackColor = false;
            this.btnActionScrollClick.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // pnlDoubleLeftClickButton
            // 
            this.pnlDoubleLeftClickButton.Controls.Add(this.btnActionDoubleLeftClick);
            this.pnlDoubleLeftClickButton.Location = new System.Drawing.Point(179, 61);
            this.pnlDoubleLeftClickButton.Name = "pnlDoubleLeftClickButton";
            this.pnlDoubleLeftClickButton.Size = new System.Drawing.Size(94, 95);
            this.pnlDoubleLeftClickButton.TabIndex = 1;
            // 
            // btnActionDoubleLeftClick
            // 
            this.btnActionDoubleLeftClick.BackColor = System.Drawing.Color.Black;
            this.btnActionDoubleLeftClick.Image = global::GazeToolBar.Properties.Resources.Double_Click_icon;
            this.btnActionDoubleLeftClick.Location = new System.Drawing.Point(2, 2);
            this.btnActionDoubleLeftClick.Margin = new System.Windows.Forms.Padding(2);
            this.btnActionDoubleLeftClick.Name = "btnActionDoubleLeftClick";
            this.btnActionDoubleLeftClick.Size = new System.Drawing.Size(90, 90);
            this.btnActionDoubleLeftClick.TabIndex = 0;
            this.btnActionDoubleLeftClick.UseVisualStyleBackColor = false;
            this.btnActionDoubleLeftClick.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2826, 753);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.pnlZoomSettings);
            this.Controls.Add(this.pnlPageKeyboard);
            this.Controls.Add(this.pnlRearrange);
            this.Controls.Add(this.pnlSwitchSetting);
            this.Controls.Add(this.panelSaveAndCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.panelSaveAndCancel.ResumeLayout(false);
            this.pnlCancel.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.pnlPageKeyboard.ResumeLayout(false);
            this.pnlPageKeyboard.PerformLayout();
            this.pnlRightClick.ResumeLayout(false);
            this.pnlRightClick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlFKeyHighlight3.ResumeLayout(false);
            this.pnlFKeyHighlight4.ResumeLayout(false);
            this.pnlDoubleClick.ResumeLayout(false);
            this.pnlDoubleClick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlFKeyHighlight5.ResumeLayout(false);
            this.pnlFKeyHighlight6.ResumeLayout(false);
            this.pnlScroll.ResumeLayout(false);
            this.pnlScroll.PerformLayout();
            this.pnlFKeyHighlight8.ResumeLayout(false);
            this.pnlFKeyHighlight7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlLeftClick.ResumeLayout(false);
            this.pnlLeftClick.PerformLayout();
            this.pnlFKeyHighlight2.ResumeLayout(false);
            this.pnlFKeyHighlight1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFKeyHighlight10.ResumeLayout(false);
            this.pnlFKeyHighlight9.ResumeLayout(false);
            this.pnlGeneralButton.ResumeLayout(false);
            this.pnlKeysButton.ResumeLayout(false);
            this.pnlSwitchSetting.ResumeLayout(false);
            this.pnlRearrangeButton.ResumeLayout(false);
            this.pnlZoomButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlZoomSize.ResumeLayout(false);
            this.pnlZoomSize.PerformLayout();
            this.pnlZoomSizeContent.ResumeLayout(false);
            this.pnlZoomSizeContent.PerformLayout();
            this.pnlZWSPlus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoomWindowSize)).EndInit();
            this.pnlZWSMinus.ResumeLayout(false);
            this.pnlZoomAmount.ResumeLayout(false);
            this.pnlZoomAmount.PerformLayout();
            this.pnlZoomAmountContent.ResumeLayout(false);
            this.pnlZIAPlus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoomAmount)).EndInit();
            this.pnlZIAMinus.ResumeLayout(false);
            this.pnlZoomSettings.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlFixationTimeOut.ResumeLayout(false);
            this.pnlFixationTimeOut.PerformLayout();
            this.pnlFixTimeOutContent.ResumeLayout(false);
            this.pnlFixTimeOutContent.PerformLayout();
            this.pnlFTOPlus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFixTimeOut)).EndInit();
            this.pnlFTOMins.ResumeLayout(false);
            this.panelOther.ResumeLayout(false);
            this.panelOther.PerformLayout();
            this.pnlOtherAuto.ResumeLayout(false);
            this.pnlOtherAuto.PerformLayout();
            this.pnlAuto.ResumeLayout(false);
            this.panelPrecision.ResumeLayout(false);
            this.panelPrecision.PerformLayout();
            this.pnlFixTimeLengthContent.ResumeLayout(false);
            this.pnlFixTimeLengthContent.PerformLayout();
            this.pnlFTLPlus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFixTimeLength)).EndInit();
            this.pnlFTLMins.ResumeLayout(false);
            this.pnlRearrange.ResumeLayout(false);
            this.pnlRearrangeControls.ResumeLayout(false);
            this.pnlMoveUpButton.ResumeLayout(false);
            this.pnlMoveDownButton.ResumeLayout(false);
            this.pnlRemoveButton.ResumeLayout(false);
            this.pnlRightClickButton.ResumeLayout(false);
            this.pnlSettingsButton.ResumeLayout(false);
            this.pnlLeftClickButton.ResumeLayout(false);
            this.pnlKeyboardButton.ResumeLayout(false);
            this.pnlScrollClickButton.ResumeLayout(false);
            this.pnlDoubleLeftClickButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSave;
        private Button btnCancel;
        private Panel panelSaveAndCancel;
        private EyeXFramework.Forms.BehaviorMap bhavSettingMap;
        private Panel pnlPageKeyboard;
        private Button btnGeneralSetting;
        private Button btnShortCutKeySetting;
        private Panel pnlLeftClick;
        private Label lbLeft;
        private Button btClearFKeyLeftClick;
        private Button btFKeyLeftClick;
        private PictureBox pictureBox1;
        private Panel pnlRightClick;
        private Label lbRight;
        private Button btClearFKeyRightClick;
        private Button btFKeyRightClick;
        private PictureBox pictureBox2;
        private Panel pnlDoubleClick;
        private Label lbDouble;
        private Button btClearFKeyDoubleClick;
        private Button btFKeyDoubleClick;
        private PictureBox pictureBox3;
        private Panel pnlScroll;
        private Label lbScroll;
        private Button btClearFKeyScroll;
        private Button btFKeyScroll;
        private PictureBox pictureBox4;
        private Button btClearFKeyDrapAndDrop;
        private Button btFKeyDrapAndDrop;
        private PictureBox pictureBox5;
        private Label lbFKeyFeedback;
        private Panel pnlFKeyHighlight3;
        private Panel pnlFKeyHighlight4;
        private Panel pnlFKeyHighlight5;
        private Panel pnlFKeyHighlight6;
        private Panel pnlFKeyHighlight8;
        private Panel pnlFKeyHighlight7;
        private Panel pnlFKeyHighlight10;
        private Panel pnlFKeyHighlight9;
        private Panel pnlFKeyHighlight2;
        private Panel pnlFKeyHighlight1;
        private Panel pnlGeneralButton;
        private Panel pnlKeysButton;
        private Panel pnlCancel;
        private Panel pnlSave;
        private Panel pnlSwitchSetting;
        private Button btnZoomSettings;
        private Button btnRearrangeSetting;
        private Panel pnlZoomSize;
        private Panel pnlZoomSizeContent;
        private Panel pnlZWSPlus;
        private Button btnZoomSizePlus;
        private TrackBar trackBarZoomWindowSize;
        private Panel pnlZWSMinus;
        private Button btnZoomSizeMinus;
        private Label labZoomWindowSize;
        private Panel pnlZoomAmount;
        private Panel pnlZoomAmountContent;
        private Panel pnlZIAPlus;
        private Button btnZoomAmountPlus;
        private TrackBar trackBarZoomAmount;
        private Panel pnlZIAMinus;
        private Button btnZoomAmountMinus;
        private Label labZoomAmount;
        private Panel pnlZoomSettings;
        private Panel pnlGeneral;
        private Panel pnlFixationTimeOut;
        private Panel pnlFixTimeOutContent;
        private Panel pnlFTOPlus;
        private Button btnFixTimeOutPlus;
        private TrackBar trackBarFixTimeOut;
        private Panel pnlFTOMins;
        private Button btnFixTimeOutMins;
        private Label lblSpeed;
        private Panel panelOther;
        private Panel pnlOtherAuto;
        private Panel pnlAuto;
        private Button btnAutoStart;
        private Label label2;
        private Label lblOther;
        private Panel panelPrecision;
        private Panel pnlFixTimeLengthContent;
        private Panel pnlFTLPlus;
        private Button btnFixTimeLengthPlus;
        private TrackBar trackBarFixTimeLength;
        private Panel pnlFTLMins;
        private Button btnFixTimeLengthMins;
        private Label lblFixationDetectionTimeLength;
        private Panel pnlRearrangeButton;
        private Panel pnlZoomButton;
        private Panel pnlRearrange;
        private Panel pnlDoubleLeftClickButton;
        private Button btnActionDoubleLeftClick;
        private Panel pnlScrollClickButton;
        private Button btnActionScrollClick;
        private Panel pnlRightClickButton;
        private Button btnActionRightClick;
        private Panel pnlSettingsButton;
        private Button btnActionSettings;
        private Panel pnlLeftClickButton;
        private Button btnActionLeftClick;
        private Panel pnlKeyboardButton;
        private Button btnActionKeyboard;
        private Panel pnlMoveUpButton;
        private Button btnMoveUp;
        private Panel pnlRemoveButton;
        private Button btnRemove;
        private Panel pnlMoveDownButton;
        private Button btnMoveDown;
        private Panel pnlRearrangeControls;
    }
}