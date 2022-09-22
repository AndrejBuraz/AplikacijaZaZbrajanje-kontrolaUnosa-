namespace Moja2WindowsAplikacija
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
            this.unosBrojaA = new System.Windows.Forms.TextBox();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.unosBrojaB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonIzracun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unosBrojaA
            // 
            this.unosBrojaA.Location = new System.Drawing.Point(12, 42);
            this.unosBrojaA.Name = "unosBrojaA";
            this.unosBrojaA.Size = new System.Drawing.Size(167, 20);
            this.unosBrojaA.TabIndex = 0;
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(12, 108);
            this.rezultat.Name = "rezultat";
            this.rezultat.ReadOnly = true;
            this.rezultat.Size = new System.Drawing.Size(167, 20);
            this.rezultat.TabIndex = 1;
            this.rezultat.TabStop = false;
            // 
            // unosBrojaB
            // 
            this.unosBrojaB.Location = new System.Drawing.Point(207, 42);
            this.unosBrojaB.Name = "unosBrojaB";
            this.unosBrojaB.Size = new System.Drawing.Size(176, 20);
            this.unosBrojaB.TabIndex = 2;
            this.unosBrojaB.TextChanged += new System.EventHandler(this.unosBrojaB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zbroj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj B";
            // 
            // buttonIzracun
            // 
            this.buttonIzracun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIzracun.Location = new System.Drawing.Point(207, 106);
            this.buttonIzracun.Name = "buttonIzracun";
            this.buttonIzracun.Size = new System.Drawing.Size(176, 23);
            this.buttonIzracun.TabIndex = 6;
            this.buttonIzracun.Text = "Izračunaj";
            this.buttonIzracun.UseVisualStyleBackColor = true;
            this.buttonIzracun.Click += new System.EventHandler(this.buttonIzracun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 475);
            this.Controls.Add(this.buttonIzracun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unosBrojaB);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.unosBrojaA);
            this.Name = "Form1";
            this.Text = "Moja 2. windows aplikacija";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unosBrojaA;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.TextBox unosBrojaB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonIzracun;
    }
}

