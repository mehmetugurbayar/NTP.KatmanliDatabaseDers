namespace NTP.KatmanlıDatabaseDers
{
    partial class frmOgrenciAra
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
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.ForeColor = System.Drawing.Color.White;
            this.lblOgrenciNo.Location = new System.Drawing.Point(30, 29);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(92, 13);
            this.lblOgrenciNo.TabIndex = 5;
            this.lblOgrenciNo.Text = "Öğrenci No Giriniz";
            // 
            // btnAra
            // 
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(33, 54);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(182, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(128, 26);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(87, 20);
            this.txtOgrenciNo.TabIndex = 3;
            // 
            // Cikis
            // 
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cikis.ForeColor = System.Drawing.Color.White;
            this.Cikis.Location = new System.Drawing.Point(33, 83);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(182, 23);
            this.Cikis.TabIndex = 6;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // frmOgrenciAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(256, 112);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.lblOgrenciNo);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtOgrenciNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOgrenciAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgrenciAra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Button Cikis;
    }
}