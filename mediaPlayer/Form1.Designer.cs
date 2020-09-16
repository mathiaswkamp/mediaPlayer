namespace mediaPlayer
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.VlcVideos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(44, 61);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(44, 115);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // VlcVideos
            // 
            this.VlcVideos.FormattingEnabled = true;
            this.VlcVideos.Location = new System.Drawing.Point(168, 35);
            this.VlcVideos.Name = "VlcVideos";
            this.VlcVideos.Size = new System.Drawing.Size(193, 147);
            this.VlcVideos.TabIndex = 3;
            this.VlcVideos.SelectedIndexChanged += new System.EventHandler(this.VlcVideos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 203);
            this.Controls.Add(this.VlcVideos);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox VlcVideos;
    }
}

