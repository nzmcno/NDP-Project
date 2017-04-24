namespace UcakSavarOyunu
{
    partial class UcakSavar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcakSavar));
            this.defansUcagi = new System.Windows.Forms.PictureBox();
            this.timerMoveDef = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.defansUcagi)).BeginInit();
            this.SuspendLayout();
            // 
            // defansUcagi
            // 
            this.defansUcagi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defansUcagi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("defansUcagi.BackgroundImage")));
            this.defansUcagi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defansUcagi.Location = new System.Drawing.Point(245, 424);
            this.defansUcagi.Name = "defansUcagi";
            this.defansUcagi.Size = new System.Drawing.Size(74, 54);
            this.defansUcagi.TabIndex = 0;
            this.defansUcagi.TabStop = false;
            // 
            // timerMoveDef
            // 
            this.timerMoveDef.Enabled = true;
            this.timerMoveDef.Tick += new System.EventHandler(this.timerMoveDef_Tick);
            // 
            // UcakSavar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(576, 478);
            this.Controls.Add(this.defansUcagi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UcakSavar";
            this.Text = "Ucak Savar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UcakSavar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.defansUcagi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox defansUcagi;
        private System.Windows.Forms.Timer timerMoveDef;
    }
}

