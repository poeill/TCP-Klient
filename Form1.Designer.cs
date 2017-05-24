namespace TCP_Klient
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
            this.Adres = new System.Windows.Forms.TextBox();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.mainport = new System.Windows.Forms.NumericUpDown();
            this.przycisk_polacz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainport)).BeginInit();
            this.SuspendLayout();
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(0, 0);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(341, 20);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            this.Adres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(12, 26);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(719, 355);
            this.info_o_polaczeniu.TabIndex = 2;
            // 
            // mainport
            // 
            this.mainport.Location = new System.Drawing.Point(357, 0);
            this.mainport.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.mainport.Name = "mainport";
            this.mainport.Size = new System.Drawing.Size(374, 20);
            this.mainport.TabIndex = 3;
            // 
            // przycisk_polacz
            // 
            this.przycisk_polacz.Location = new System.Drawing.Point(278, 387);
            this.przycisk_polacz.Name = "przycisk_polacz";
            this.przycisk_polacz.Size = new System.Drawing.Size(143, 45);
            this.przycisk_polacz.TabIndex = 4;
            this.przycisk_polacz.Text = "polacz";
            this.przycisk_polacz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 458);
            this.Controls.Add(this.przycisk_polacz);
            this.Controls.Add(this.mainport);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.Adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.NumericUpDown mainport;
        private System.Windows.Forms.Button przycisk_polacz;
    }
}

