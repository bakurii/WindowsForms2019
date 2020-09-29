namespace _16matikkapeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.plusNappi = new System.Windows.Forms.Button();
            this.miinusNappi = new System.Windows.Forms.Button();
            this.kertoNappi = new System.Windows.Forms.Button();
            this.jakoNappi = new System.Windows.Forms.Button();
            this.pisteNappi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matikkapeli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusNappi
            // 
            this.plusNappi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.plusNappi.Location = new System.Drawing.Point(38, 107);
            this.plusNappi.Name = "plusNappi";
            this.plusNappi.Size = new System.Drawing.Size(163, 45);
            this.plusNappi.TabIndex = 1;
            this.plusNappi.Text = "Pluslasku";
            this.plusNappi.UseVisualStyleBackColor = false;
            this.plusNappi.Click += new System.EventHandler(this.PlusNappi_Click);
            // 
            // miinusNappi
            // 
            this.miinusNappi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.miinusNappi.Location = new System.Drawing.Point(327, 107);
            this.miinusNappi.Name = "miinusNappi";
            this.miinusNappi.Size = new System.Drawing.Size(166, 45);
            this.miinusNappi.TabIndex = 2;
            this.miinusNappi.Text = "Miinuslasku";
            this.miinusNappi.UseVisualStyleBackColor = false;
            this.miinusNappi.Click += new System.EventHandler(this.MiinusNappi_Click);
            // 
            // kertoNappi
            // 
            this.kertoNappi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kertoNappi.Location = new System.Drawing.Point(38, 196);
            this.kertoNappi.Name = "kertoNappi";
            this.kertoNappi.Size = new System.Drawing.Size(163, 46);
            this.kertoNappi.TabIndex = 3;
            this.kertoNappi.Text = "Kertolasku";
            this.kertoNappi.UseVisualStyleBackColor = false;
            this.kertoNappi.Click += new System.EventHandler(this.KertoNappi_Click);
            // 
            // jakoNappi
            // 
            this.jakoNappi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.jakoNappi.Location = new System.Drawing.Point(327, 196);
            this.jakoNappi.Name = "jakoNappi";
            this.jakoNappi.Size = new System.Drawing.Size(166, 46);
            this.jakoNappi.TabIndex = 4;
            this.jakoNappi.Text = "Jakolasku";
            this.jakoNappi.UseVisualStyleBackColor = false;
            this.jakoNappi.Click += new System.EventHandler(this.JakoNappi_Click);
            // 
            // pisteNappi
            // 
            this.pisteNappi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pisteNappi.Location = new System.Drawing.Point(38, 290);
            this.pisteNappi.Name = "pisteNappi";
            this.pisteNappi.Size = new System.Drawing.Size(455, 37);
            this.pisteNappi.TabIndex = 5;
            this.pisteNappi.Text = "Pisteesi";
            this.pisteNappi.UseVisualStyleBackColor = false;
            this.pisteNappi.Click += new System.EventHandler(this.PisteNappi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.PoistuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(538, 523);
            this.Controls.Add(this.pisteNappi);
            this.Controls.Add(this.jakoNappi);
            this.Controls.Add(this.kertoNappi);
            this.Controls.Add(this.miinusNappi);
            this.Controls.Add(this.plusNappi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plusNappi;
        private System.Windows.Forms.Button miinusNappi;
        private System.Windows.Forms.Button kertoNappi;
        private System.Windows.Forms.Button jakoNappi;
        private System.Windows.Forms.Button pisteNappi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
    }
}

