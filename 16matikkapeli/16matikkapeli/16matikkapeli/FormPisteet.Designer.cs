namespace _16matikkapeli
{
    partial class FormPisteet
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
            this.otsikko = new System.Windows.Forms.Label();
            this.otsikko2 = new System.Windows.Forms.Label();
            this.pisteet = new System.Windows.Forms.Label();
            this.saavutus1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otsikko
            // 
            this.otsikko.AutoSize = true;
            this.otsikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otsikko.Location = new System.Drawing.Point(55, 27);
            this.otsikko.Name = "otsikko";
            this.otsikko.Size = new System.Drawing.Size(68, 20);
            this.otsikko.TabIndex = 0;
            this.otsikko.Text = "Pisteet";
            // 
            // otsikko2
            // 
            this.otsikko2.AutoSize = true;
            this.otsikko2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otsikko2.Location = new System.Drawing.Point(437, 27);
            this.otsikko2.Name = "otsikko2";
            this.otsikko2.Size = new System.Drawing.Size(111, 20);
            this.otsikko2.TabIndex = 1;
            this.otsikko2.Text = "Saavutukset";
            // 
            // pisteet
            // 
            this.pisteet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pisteet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisteet.Location = new System.Drawing.Point(55, 76);
            this.pisteet.Name = "pisteet";
            this.pisteet.Size = new System.Drawing.Size(124, 43);
            this.pisteet.TabIndex = 2;
            // 
            // saavutus1
            // 
            this.saavutus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saavutus1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saavutus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saavutus1.Location = new System.Drawing.Point(437, 76);
            this.saavutus1.Name = "saavutus1";
            this.saavutus1.Size = new System.Drawing.Size(266, 43);
            this.saavutus1.TabIndex = 3;
            this.saavutus1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPisteet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(739, 203);
            this.Controls.Add(this.saavutus1);
            this.Controls.Add(this.pisteet);
            this.Controls.Add(this.otsikko2);
            this.Controls.Add(this.otsikko);
            this.Name = "FormPisteet";
            this.Text = "FormPisteet";
            this.Load += new System.EventHandler(this.FormPisteet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikko;
        private System.Windows.Forms.Label otsikko2;
        private System.Windows.Forms.Label pisteet;
        private System.Windows.Forms.Label saavutus1;
    }
}