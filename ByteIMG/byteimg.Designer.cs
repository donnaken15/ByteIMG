namespace ByteIMG
{
    partial class byteimg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(byteimg));
            this.opendialog = new System.Windows.Forms.OpenFileDialog();
            this.image = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // opendialog
            // 
            this.opendialog.Filter = "ByteIMG|*.bim";
            this.opendialog.FileOk += new System.ComponentModel.CancelEventHandler(this.opendialog_FileOk);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(292, 264);
            this.image.TabIndex = 0;
            // 
            // byteimg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(292, 264);
            this.Controls.Add(this.image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "byteimg";
            this.ShowIcon = false;
            this.Text = "ByteIMG";
            this.Load += new System.EventHandler(this.byteimg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opendialog;
        private System.Windows.Forms.Panel image;
    }
}

