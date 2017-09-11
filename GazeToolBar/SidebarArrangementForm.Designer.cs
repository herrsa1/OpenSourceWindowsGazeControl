namespace GazeToolBar
{
    partial class SidebarArrangementForm
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
            this.btnActionSettings = new System.Windows.Forms.Button();
            this.btnActionLeftClick = new System.Windows.Forms.Button();
            this.btnActionKeyboard = new System.Windows.Forms.Button();
            this.btnActionScrollClick = new System.Windows.Forms.Button();
            this.btnActionDoubleLeftClick = new System.Windows.Forms.Button();
            this.btnActionRightClick = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.panelArrows = new System.Windows.Forms.Panel();
            this.behaviorMap1 = new EyeXFramework.Forms.BehaviorMap(this.components);
            this.panelArrows.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActionSettings
            // 
            this.btnActionSettings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActionSettings.Image = global::GazeToolBar.Properties.Resources.settings_icon;
            this.btnActionSettings.Location = new System.Drawing.Point(90, 83);
            this.btnActionSettings.Name = "btnActionSettings";
            this.btnActionSettings.Size = new System.Drawing.Size(100, 100);
            this.btnActionSettings.TabIndex = 5;
            this.btnActionSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActionSettings.UseVisualStyleBackColor = false;
            this.btnActionSettings.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // btnActionLeftClick
            // 
            this.btnActionLeftClick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActionLeftClick.Image = global::GazeToolBar.Properties.Resources.Left_Click_icon;
            this.btnActionLeftClick.Location = new System.Drawing.Point(469, 261);
            this.btnActionLeftClick.Name = "btnActionLeftClick";
            this.btnActionLeftClick.Size = new System.Drawing.Size(100, 100);
            this.btnActionLeftClick.TabIndex = 4;
            this.btnActionLeftClick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActionLeftClick.UseVisualStyleBackColor = false;
            this.btnActionLeftClick.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // btnActionKeyboard
            // 
            this.btnActionKeyboard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActionKeyboard.Image = global::GazeToolBar.Properties.Resources.Keyboard_icon;
            this.btnActionKeyboard.Location = new System.Drawing.Point(469, 465);
            this.btnActionKeyboard.Name = "btnActionKeyboard";
            this.btnActionKeyboard.Size = new System.Drawing.Size(100, 100);
            this.btnActionKeyboard.TabIndex = 3;
            this.btnActionKeyboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActionKeyboard.UseVisualStyleBackColor = false;
            this.btnActionKeyboard.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // btnActionScrollClick
            // 
            this.btnActionScrollClick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActionScrollClick.Image = global::GazeToolBar.Properties.Resources.Scroll_icon;
            this.btnActionScrollClick.Location = new System.Drawing.Point(255, 624);
            this.btnActionScrollClick.Name = "btnActionScrollClick";
            this.btnActionScrollClick.Size = new System.Drawing.Size(100, 100);
            this.btnActionScrollClick.TabIndex = 2;
            this.btnActionScrollClick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActionScrollClick.UseVisualStyleBackColor = false;
            this.btnActionScrollClick.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // btnActionDoubleLeftClick
            // 
            this.btnActionDoubleLeftClick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActionDoubleLeftClick.Image = global::GazeToolBar.Properties.Resources.Double_Click_icon;
            this.btnActionDoubleLeftClick.Location = new System.Drawing.Point(255, 261);
            this.btnActionDoubleLeftClick.Name = "btnActionDoubleLeftClick";
            this.btnActionDoubleLeftClick.Size = new System.Drawing.Size(100, 100);
            this.btnActionDoubleLeftClick.TabIndex = 11;
            this.btnActionDoubleLeftClick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActionDoubleLeftClick.UseVisualStyleBackColor = false;
            this.btnActionDoubleLeftClick.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // btnActionRightClick
            // 
            this.btnActionRightClick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActionRightClick.Image = global::GazeToolBar.Properties.Resources.Right_Click_icon;
            this.btnActionRightClick.Location = new System.Drawing.Point(255, 465);
            this.btnActionRightClick.Name = "btnActionRightClick";
            this.btnActionRightClick.Size = new System.Drawing.Size(100, 100);
            this.btnActionRightClick.TabIndex = 0;
            this.btnActionRightClick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActionRightClick.UseVisualStyleBackColor = false;
            this.btnActionRightClick.Click += new System.EventHandler(this.btnActionButtonClick_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMoveDown.Image = global::GazeToolBar.Properties.Resources.button_down;
            this.btnMoveDown.Location = new System.Drawing.Point(12, 383);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(100, 100);
            this.btnMoveDown.TabIndex = 9;
            this.btnMoveDown.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.Image = global::GazeToolBar.Properties.Resources.button_left;
            this.btnRemove.Location = new System.Drawing.Point(12, 207);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 100);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMoveUp.Image = global::GazeToolBar.Properties.Resources.button_up;
            this.btnMoveUp.Location = new System.Drawing.Point(12, 13);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(100, 100);
            this.btnMoveUp.TabIndex = 6;
            this.btnMoveUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // panelArrows
            // 
            this.panelArrows.Controls.Add(this.btnMoveUp);
            this.panelArrows.Controls.Add(this.btnRemove);
            this.panelArrows.Controls.Add(this.btnMoveDown);
            this.panelArrows.Location = new System.Drawing.Point(711, 130);
            this.panelArrows.Name = "panelArrows";
            this.panelArrows.Size = new System.Drawing.Size(120, 500);
            this.panelArrows.TabIndex = 32;
            // 
            // SidebarArrangementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelArrows);
            this.Controls.Add(this.btnActionSettings);
            this.Controls.Add(this.btnActionLeftClick);
            this.Controls.Add(this.btnActionKeyboard);
            this.Controls.Add(this.btnActionScrollClick);
            this.Controls.Add(this.btnActionDoubleLeftClick);
            this.Controls.Add(this.btnActionRightClick);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SidebarArrangementForm";
            this.Text = "SidebarArrangementForm";
            this.Load += new System.EventHandler(this.SidebarArrangementForm_Load);
            this.Controls.SetChildIndex(this.btnActionRightClick, 0);
            this.Controls.SetChildIndex(this.btnActionDoubleLeftClick, 0);
            this.Controls.SetChildIndex(this.btnActionScrollClick, 0);
            this.Controls.SetChildIndex(this.btnActionKeyboard, 0);
            this.Controls.SetChildIndex(this.btnActionLeftClick, 0);
            this.Controls.SetChildIndex(this.btnActionSettings, 0);
            this.Controls.SetChildIndex(this.panelArrows, 0);
            this.panelArrows.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnActionRightClick;
        private System.Windows.Forms.Button btnActionDoubleLeftClick;
        private System.Windows.Forms.Button btnActionScrollClick;
        private System.Windows.Forms.Button btnActionKeyboard;
        private System.Windows.Forms.Button btnActionLeftClick;
        private System.Windows.Forms.Button btnActionSettings;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Panel panelArrows;
        private EyeXFramework.Forms.BehaviorMap behaviorMap1;
    }
}