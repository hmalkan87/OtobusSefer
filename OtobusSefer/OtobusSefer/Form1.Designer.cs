﻿namespace OtobusSefer
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Nerden = new System.Windows.Forms.ComboBox();
            this.cmb_Nereye = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nerden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nereye";
            // 
            // cmb_Nerden
            // 
            this.cmb_Nerden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nerden.FormattingEnabled = true;
            this.cmb_Nerden.Location = new System.Drawing.Point(46, 69);
            this.cmb_Nerden.Name = "cmb_Nerden";
            this.cmb_Nerden.Size = new System.Drawing.Size(121, 21);
            this.cmb_Nerden.TabIndex = 4;
            this.cmb_Nerden.SelectedIndexChanged += new System.EventHandler(this.cmb_Nerden_SelectedIndexChanged);
            // 
            // cmb_Nereye
            // 
            this.cmb_Nereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nereye.FormattingEnabled = true;
            this.cmb_Nereye.Location = new System.Drawing.Point(230, 69);
            this.cmb_Nereye.Name = "cmb_Nereye";
            this.cmb_Nereye.Size = new System.Drawing.Size(121, 21);
            this.cmb_Nereye.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 265);
            this.Controls.Add(this.cmb_Nereye);
            this.Controls.Add(this.cmb_Nerden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Nerden;
        private System.Windows.Forms.ComboBox cmb_Nereye;
    }
}

