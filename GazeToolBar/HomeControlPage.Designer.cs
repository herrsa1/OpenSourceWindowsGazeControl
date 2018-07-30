using System.Windows.Forms;

namespace GazeToolBar
{
    partial class HomeControlPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControlPage));
            this.bhavHomeControlPageMap = new EyeXFramework.Forms.BehaviorMap(this.components);
            this.pnlHomeCancel = new System.Windows.Forms.Panel();
            this.btnHomeCancel = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.btn3 = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btn2 = new System.Windows.Forms.Button();
            this.pnlHomeCancel.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHomeCancel
            // 
            this.pnlHomeCancel.Controls.Add(this.btnHomeCancel);
            this.pnlHomeCancel.Location = new System.Drawing.Point(809, 925);
            this.pnlHomeCancel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHomeCancel.Name = "pnlHomeCancel";
            this.pnlHomeCancel.Size = new System.Drawing.Size(154, 105);
            this.pnlHomeCancel.TabIndex = 23;
            // 
            // btnHomeCancel
            // 
            this.btnHomeCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeCancel.FlatAppearance.BorderSize = 5;
            this.btnHomeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeCancel.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnHomeCancel.ForeColor = System.Drawing.Color.White;
            this.btnHomeCancel.Location = new System.Drawing.Point(2, 2);
            this.btnHomeCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeCancel.Name = "btnHomeCancel";
            this.btnHomeCancel.Size = new System.Drawing.Size(150, 100);
            this.btnHomeCancel.TabIndex = 29;
            this.btnHomeCancel.Text = "Cancel";
            this.btnHomeCancel.UseVisualStyleBackColor = false;
            this.btnHomeCancel.Click += new System.EventHandler(this.btnHomeCancel_Click);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btn1);
            this.pnl1.Location = new System.Drawing.Point(42, 17);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(154, 155);
            this.pnl1.TabIndex = 26;
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderSize = 5;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Arial", 24F);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Image = global::GazeToolBar.Properties.Resources.heater;
            this.btn1.Location = new System.Drawing.Point(2, -1);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 150);
            this.btn1.TabIndex = 2;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pnl3
            // 
            this.pnl3.Controls.Add(this.btn3);
            this.pnl3.Location = new System.Drawing.Point(604, 20);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(154, 155);
            this.pnl3.TabIndex = 25;
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderSize = 5;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Arial", 24F);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Image = global::GazeToolBar.Properties.Resources.tv;
            this.btn3.Location = new System.Drawing.Point(2, 2);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 150);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.btn2);
            this.pnl2.Location = new System.Drawing.Point(324, 17);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(154, 155);
            this.pnl2.TabIndex = 24;
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 5;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Arial", 24F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Image = global::GazeToolBar.Properties.Resources.Light;
            this.btn2.Location = new System.Drawing.Point(0, 3);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 150);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // HomeControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnlHomeCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeControlPage";
            this.Text = "HomeControlPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeControlPage_FormClosed);
            this.Load += new System.EventHandler(this.HomeControlPage_Load);
            this.Shown += new System.EventHandler(this.HomeControlPage_Shown);
            this.pnlHomeCancel.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl3.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private EyeXFramework.Forms.BehaviorMap bhavHomeControlPageMap;
        private Panel pnlHomeCancel;
        private Button btnHomeCancel;
        private Panel pnl1;
        private Button btn1;
        private Panel pnl3;
        private Button btn3;
        private Panel pnl2;
        private Button btn2;
    }
}