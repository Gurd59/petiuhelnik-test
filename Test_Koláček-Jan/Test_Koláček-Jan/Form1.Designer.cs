namespace Test_Koláček_Jan
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_pozice = new System.Windows.Forms.Label();
            this.nmr_strana = new System.Windows.Forms.NumericUpDown();
            this.txt_jednotky = new System.Windows.Forms.TextBox();
            this.txt_vystup = new System.Windows.Forms.TextBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_novyzaznam = new System.Windows.Forms.Button();
            this.btn_v = new System.Windows.Forms.Button();
            this.btn_smazzaznam = new System.Windows.Forms.Button();
            this.btn_do = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_strana)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pozice v listu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label2.Location = new System.Drawing.Point(49, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label3.Location = new System.Drawing.Point(49, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jednotky:";
            // 
            // lbl_pozice
            // 
            this.lbl_pozice.AutoSize = true;
            this.lbl_pozice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lbl_pozice.Location = new System.Drawing.Point(234, 42);
            this.lbl_pozice.Name = "lbl_pozice";
            this.lbl_pozice.Size = new System.Drawing.Size(29, 31);
            this.lbl_pozice.TabIndex = 3;
            this.lbl_pozice.Text = "0";
            // 
            // nmr_strana
            // 
            this.nmr_strana.DecimalPlaces = 2;
            this.nmr_strana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.nmr_strana.Location = new System.Drawing.Point(240, 92);
            this.nmr_strana.Name = "nmr_strana";
            this.nmr_strana.Size = new System.Drawing.Size(116, 37);
            this.nmr_strana.TabIndex = 4;
            // 
            // txt_jednotky
            // 
            this.txt_jednotky.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txt_jednotky.Location = new System.Drawing.Point(240, 140);
            this.txt_jednotky.Name = "txt_jednotky";
            this.txt_jednotky.Size = new System.Drawing.Size(116, 37);
            this.txt_jednotky.TabIndex = 5;
            // 
            // txt_vystup
            // 
            this.txt_vystup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txt_vystup.Location = new System.Drawing.Point(386, 42);
            this.txt_vystup.Multiline = true;
            this.txt_vystup.Name = "txt_vystup";
            this.txt_vystup.Size = new System.Drawing.Size(385, 135);
            this.txt_vystup.TabIndex = 6;
            // 
            // btn_prev
            // 
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_prev.Location = new System.Drawing.Point(55, 208);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(57, 211);
            this.btn_prev.TabIndex = 7;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_next.Location = new System.Drawing.Point(714, 208);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(57, 211);
            this.btn_next.TabIndex = 8;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_novyzaznam
            // 
            this.btn_novyzaznam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_novyzaznam.Location = new System.Drawing.Point(140, 208);
            this.btn_novyzaznam.Name = "btn_novyzaznam";
            this.btn_novyzaznam.Size = new System.Drawing.Size(550, 48);
            this.btn_novyzaznam.TabIndex = 9;
            this.btn_novyzaznam.Text = "Nový záznam";
            this.btn_novyzaznam.UseVisualStyleBackColor = true;
            this.btn_novyzaznam.Click += new System.EventHandler(this.btn_novyzaznam_Click);
            // 
            // btn_v
            // 
            this.btn_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_v.Location = new System.Drawing.Point(140, 262);
            this.btn_v.Name = "btn_v";
            this.btn_v.Size = new System.Drawing.Size(550, 48);
            this.btn_v.TabIndex = 10;
            this.btn_v.Text = "Uložit změny v záznamu";
            this.btn_v.UseVisualStyleBackColor = true;
            this.btn_v.Click += new System.EventHandler(this.btn_v_Click);
            // 
            // btn_smazzaznam
            // 
            this.btn_smazzaznam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_smazzaznam.Location = new System.Drawing.Point(140, 316);
            this.btn_smazzaznam.Name = "btn_smazzaznam";
            this.btn_smazzaznam.Size = new System.Drawing.Size(550, 48);
            this.btn_smazzaznam.TabIndex = 11;
            this.btn_smazzaznam.Text = "Smaž záznam";
            this.btn_smazzaznam.UseVisualStyleBackColor = true;
            this.btn_smazzaznam.Click += new System.EventHandler(this.btn_smazzaznam_Click);
            // 
            // btn_do
            // 
            this.btn_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_do.Location = new System.Drawing.Point(140, 371);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(550, 48);
            this.btn_do.TabIndex = 12;
            this.btn_do.Text = "Ulož změny do záznamu";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_do);
            this.Controls.Add(this.btn_smazzaznam);
            this.Controls.Add(this.btn_v);
            this.Controls.Add(this.btn_novyzaznam);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.txt_vystup);
            this.Controls.Add(this.txt_jednotky);
            this.Controls.Add(this.nmr_strana);
            this.Controls.Add(this.lbl_pozice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pětiúhelník";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_strana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_pozice;
        private System.Windows.Forms.NumericUpDown nmr_strana;
        private System.Windows.Forms.TextBox txt_jednotky;
        private System.Windows.Forms.TextBox txt_vystup;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_novyzaznam;
        private System.Windows.Forms.Button btn_v;
        private System.Windows.Forms.Button btn_smazzaznam;
        private System.Windows.Forms.Button btn_do;
    }
}

