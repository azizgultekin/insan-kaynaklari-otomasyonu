namespace odev1_deneme
{
    partial class ik
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
            this.button1 = new System.Windows.Forms.Button();
            this.ik_tümliste_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ik_ad_listele_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ik_min_deneyim_suresi_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ik_belirli_yas_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ik_belirli_tip_ehliyet_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ik_mezun_dg_txt = new System.Windows.Forms.ComboBox();
            this.ik_arama_yap_txt = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.ListBox();
            this.ik_inorder_rb = new System.Windows.Forms.RadioButton();
            this.ik_postorder_rb = new System.Windows.Forms.RadioButton();
            this.ik_preorder_rb = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ik_yabancidil_txt = new System.Windows.Forms.TextBox();
            this.ik_ad_listele_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çıktı Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ik_tümliste_btn
            // 
            this.ik_tümliste_btn.Location = new System.Drawing.Point(95, 183);
            this.ik_tümliste_btn.Name = "ik_tümliste_btn";
            this.ik_tümliste_btn.Size = new System.Drawing.Size(81, 41);
            this.ik_tümliste_btn.TabIndex = 2;
            this.ik_tümliste_btn.Text = "Tüm Kişileri Listele ";
            this.ik_tümliste_btn.UseVisualStyleBackColor = true;
            this.ik_tümliste_btn.Click += new System.EventHandler(this.ik_tümliste_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad ile Listeleme";
            // 
            // ik_ad_listele_txt
            // 
            this.ik_ad_listele_txt.Location = new System.Drawing.Point(12, 26);
            this.ik_ad_listele_txt.Name = "ik_ad_listele_txt";
            this.ik_ad_listele_txt.Size = new System.Drawing.Size(155, 23);
            this.ik_ad_listele_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mezun Durumuna Göre Listeleme\r\n";
            // 
            // ik_min_deneyim_suresi_cmb
            // 
            this.ik_min_deneyim_suresi_cmb.FormattingEnabled = true;
            this.ik_min_deneyim_suresi_cmb.Items.AddRange(new object[] {
            "0 ",
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20"});
            this.ik_min_deneyim_suresi_cmb.Location = new System.Drawing.Point(259, 27);
            this.ik_min_deneyim_suresi_cmb.Name = "ik_min_deneyim_suresi_cmb";
            this.ik_min_deneyim_suresi_cmb.Size = new System.Drawing.Size(65, 23);
            this.ik_min_deneyim_suresi_cmb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Minumum Deneyim Süresine Göre Listeleme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Belirli Yaş Değeri Altındaki Kişiler Göre Listeleme\r\n";
            // 
            // ik_belirli_yas_txt
            // 
            this.ik_belirli_yas_txt.Location = new System.Drawing.Point(260, 83);
            this.ik_belirli_yas_txt.Name = "ik_belirli_yas_txt";
            this.ik_belirli_yas_txt.Size = new System.Drawing.Size(64, 23);
            this.ik_belirli_yas_txt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Belirli Tip Ehliyeti Olan Kişilere Göre Listeleme";
            // 
            // ik_belirli_tip_ehliyet_txt
            // 
            this.ik_belirli_tip_ehliyet_txt.Location = new System.Drawing.Point(260, 140);
            this.ik_belirli_tip_ehliyet_txt.Name = "ik_belirli_tip_ehliyet_txt";
            this.ik_belirli_tip_ehliyet_txt.Size = new System.Drawing.Size(109, 23);
            this.ik_belirli_tip_ehliyet_txt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Yabancı Dil Bilenlere Göre Listeleme";
            // 
            // ik_mezun_dg_txt
            // 
            this.ik_mezun_dg_txt.FormattingEnabled = true;
            this.ik_mezun_dg_txt.Items.AddRange(new object[] {
            "lise",
            "yüksek okul",
            "lisans",
            "yüksek lisans",
            "doktora"});
            this.ik_mezun_dg_txt.Location = new System.Drawing.Point(13, 80);
            this.ik_mezun_dg_txt.Name = "ik_mezun_dg_txt";
            this.ik_mezun_dg_txt.Size = new System.Drawing.Size(153, 23);
            this.ik_mezun_dg_txt.TabIndex = 15;
            // 
            // ik_arama_yap_txt
            // 
            this.ik_arama_yap_txt.Location = new System.Drawing.Point(13, 183);
            this.ik_arama_yap_txt.Name = "ik_arama_yap_txt";
            this.ik_arama_yap_txt.Size = new System.Drawing.Size(76, 41);
            this.ik_arama_yap_txt.TabIndex = 16;
            this.ik_arama_yap_txt.Text = "Arama Yap";
            this.ik_arama_yap_txt.UseVisualStyleBackColor = true;
            this.ik_arama_yap_txt.Click += new System.EventHandler(this.ik_arama_yap_txt_Click);
            // 
            // l
            // 
            this.l.FormattingEnabled = true;
            this.l.ItemHeight = 15;
            this.l.Location = new System.Drawing.Point(7, 241);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(510, 409);
            this.l.TabIndex = 20;
            // 
            // ik_inorder_rb
            // 
            this.ik_inorder_rb.AutoSize = true;
            this.ik_inorder_rb.Checked = true;
            this.ik_inorder_rb.Location = new System.Drawing.Point(277, 169);
            this.ik_inorder_rb.Name = "ik_inorder_rb";
            this.ik_inorder_rb.Size = new System.Drawing.Size(65, 19);
            this.ik_inorder_rb.TabIndex = 21;
            this.ik_inorder_rb.TabStop = true;
            this.ik_inorder_rb.Text = "İnOrder";
            this.ik_inorder_rb.UseVisualStyleBackColor = true;
            // 
            // ik_postorder_rb
            // 
            this.ik_postorder_rb.AutoSize = true;
            this.ik_postorder_rb.Location = new System.Drawing.Point(277, 219);
            this.ik_postorder_rb.Name = "ik_postorder_rb";
            this.ik_postorder_rb.Size = new System.Drawing.Size(78, 19);
            this.ik_postorder_rb.TabIndex = 21;
            this.ik_postorder_rb.TabStop = true;
            this.ik_postorder_rb.Text = "PostOrder";
            this.ik_postorder_rb.UseVisualStyleBackColor = true;
            this.ik_postorder_rb.CheckedChanged += new System.EventHandler(this.ik_postorder_rb_CheckedChanged);
            // 
            // ik_preorder_rb
            // 
            this.ik_preorder_rb.AutoSize = true;
            this.ik_preorder_rb.Location = new System.Drawing.Point(277, 194);
            this.ik_preorder_rb.Name = "ik_preorder_rb";
            this.ik_preorder_rb.Size = new System.Drawing.Size(72, 19);
            this.ik_preorder_rb.TabIndex = 21;
            this.ik_preorder_rb.TabStop = true;
            this.ik_preorder_rb.Text = "PreOrder";
            this.ik_preorder_rb.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Eleman Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Derinlik: ";
            // 
            // ik_yabancidil_txt
            // 
            this.ik_yabancidil_txt.Location = new System.Drawing.Point(13, 139);
            this.ik_yabancidil_txt.Name = "ik_yabancidil_txt";
            this.ik_yabancidil_txt.Size = new System.Drawing.Size(154, 23);
            this.ik_yabancidil_txt.TabIndex = 24;
            // 
            // ik_ad_listele_btn
            // 
            this.ik_ad_listele_btn.Location = new System.Drawing.Point(182, 183);
            this.ik_ad_listele_btn.Name = "ik_ad_listele_btn";
            this.ik_ad_listele_btn.Size = new System.Drawing.Size(81, 41);
            this.ik_ad_listele_btn.TabIndex = 25;
            this.ik_ad_listele_btn.Text = "Ad İle Listeleme ";
            this.ik_ad_listele_btn.UseVisualStyleBackColor = true;
            this.ik_ad_listele_btn.Click += new System.EventHandler(this.ik_ad_listele_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 650);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ik_ad_listele_btn);
            this.Controls.Add(this.ik_yabancidil_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ik_preorder_rb);
            this.Controls.Add(this.ik_postorder_rb);
            this.Controls.Add(this.ik_inorder_rb);
            this.Controls.Add(this.l);
            this.Controls.Add(this.ik_arama_yap_txt);
            this.Controls.Add(this.ik_mezun_dg_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ik_belirli_tip_ehliyet_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ik_belirli_yas_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ik_min_deneyim_suresi_cmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ik_ad_listele_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ik_tümliste_btn);
            this.Controls.Add(this.button1);
            this.Name = "ik";
            this.Text = "İnsan Kaynakları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ik_FormClosing);
            this.Load += new System.EventHandler(this.ik_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ik_tümliste_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ik_ad_listele_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ik_yabancidil_cmb;
        private System.Windows.Forms.ComboBox ik_min_deneyim_suresi_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ik_belirli_yas_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ik_belirli_tip_ehliyet_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ik_mezun_dg_txt;
        private System.Windows.Forms.Button ik_arama_yap_txt;
        private System.Windows.Forms.ListBox l;
        private System.Windows.Forms.RadioButton ik_inorder_rb;
        private System.Windows.Forms.RadioButton ik_postorder_rb;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton ik_preorder_rb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ik_yabancidil_txt;
        private System.Windows.Forms.Button ik_ad_listele_btn;
        private System.Windows.Forms.Button button2;
    }
}