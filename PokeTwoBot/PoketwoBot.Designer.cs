
namespace PokeTwoBot
{
    partial class PoketwoBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoketwoBot));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.TitleLbL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PokeBotLog = new System.Windows.Forms.ListBox();
            this.StartFarmer = new Siticone.UI.WinForms.SiticoneButton();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TitleBar.Controls.Add(this.siticoneControlBox1);
            this.TitleBar.Controls.Add(this.TitleLbL);
            this.TitleBar.Location = new System.Drawing.Point(-8, -8);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(414, 37);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(369, 8);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 2;
            // 
            // TitleLbL
            // 
            this.TitleLbL.AutoSize = true;
            this.TitleLbL.Location = new System.Drawing.Point(14, 16);
            this.TitleLbL.Name = "TitleLbL";
            this.TitleLbL.Size = new System.Drawing.Size(137, 13);
            this.TitleLbL.TabIndex = 1;
            this.TitleLbL.Text = "PokeTwo farm | snow + null";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PokeBotLog
            // 
            this.PokeBotLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PokeBotLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PokeBotLog.ForeColor = System.Drawing.Color.White;
            this.PokeBotLog.FormattingEnabled = true;
            this.PokeBotLog.Location = new System.Drawing.Point(12, 165);
            this.PokeBotLog.Name = "PokeBotLog";
            this.PokeBotLog.Size = new System.Drawing.Size(381, 195);
            this.PokeBotLog.TabIndex = 2;
            // 
            // StartFarmer
            // 
            this.StartFarmer.CheckedState.Parent = this.StartFarmer;
            this.StartFarmer.CustomImages.Parent = this.StartFarmer;
            this.StartFarmer.FillColor = System.Drawing.Color.Green;
            this.StartFarmer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartFarmer.ForeColor = System.Drawing.Color.White;
            this.StartFarmer.HoveredState.Parent = this.StartFarmer;
            this.StartFarmer.Location = new System.Drawing.Point(12, 366);
            this.StartFarmer.Name = "StartFarmer";
            this.StartFarmer.ShadowDecoration.Parent = this.StartFarmer;
            this.StartFarmer.Size = new System.Drawing.Size(381, 45);
            this.StartFarmer.TabIndex = 3;
            this.StartFarmer.Text = "Start";
            this.StartFarmer.Click += new System.EventHandler(this.StartFarmer_Click);
            // 
            // PoketwoBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(405, 420);
            this.Controls.Add(this.StartFarmer);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.PokeBotLog);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PoketwoBot";
            this.Text = "PoketwoBot";
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Label TitleLbL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox PokeBotLog;
        private Siticone.UI.WinForms.SiticoneButton StartFarmer;
    }
}

