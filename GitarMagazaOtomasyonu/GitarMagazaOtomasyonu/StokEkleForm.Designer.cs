namespace GitarMagazaOtomasyonu
{
    partial class StokEkleForm
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
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            txtMarka = new DevExpress.XtraEditors.TextEdit();
            txtModel = new DevExpress.XtraEditors.TextEdit();
            txtKdv = new DevExpress.XtraEditors.TextEdit();
            txtStokSayisi = new DevExpress.XtraEditors.TextEdit();
            txtSatis = new DevExpress.XtraEditors.TextEdit();
            txtAlis = new DevExpress.XtraEditors.TextEdit();
            txtUretimYili = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtMarka.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtModel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKdv.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStokSayisi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSatis.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAlis.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUretimYili.Properties).BeginInit();
            SuspendLayout();
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = System.Drawing.Color.Black;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Location = new System.Drawing.Point(162, 159);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(118, 36);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "Yeni Ürünü Kaydet";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // txtMarka
            // 
            txtMarka.Location = new System.Drawing.Point(79, 14);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new System.Drawing.Size(132, 22);
            txtMarka.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Location = new System.Drawing.Point(293, 14);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(132, 22);
            txtModel.TabIndex = 3;
            // 
            // txtKdv
            // 
            txtKdv.Location = new System.Drawing.Point(79, 52);
            txtKdv.Name = "txtKdv";
            txtKdv.Size = new System.Drawing.Size(132, 22);
            txtKdv.TabIndex = 4;
            // 
            // txtStokSayisi
            // 
            txtStokSayisi.Location = new System.Drawing.Point(293, 52);
            txtStokSayisi.Name = "txtStokSayisi";
            txtStokSayisi.Size = new System.Drawing.Size(132, 22);
            txtStokSayisi.TabIndex = 5;
            // 
            // txtSatis
            // 
            txtSatis.Location = new System.Drawing.Point(293, 90);
            txtSatis.Name = "txtSatis";
            txtSatis.Size = new System.Drawing.Size(132, 22);
            txtSatis.TabIndex = 6;
            // 
            // txtAlis
            // 
            txtAlis.Location = new System.Drawing.Point(79, 90);
            txtAlis.Name = "txtAlis";
            txtAlis.Size = new System.Drawing.Size(132, 22);
            txtAlis.TabIndex = 8;
            // 
            // txtUretimYili
            // 
            txtUretimYili.Location = new System.Drawing.Point(208, 124);
            txtUretimYili.Name = "txtUretimYili";
            txtUretimYili.Size = new System.Drawing.Size(132, 22);
            txtUretimYili.TabIndex = 9;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl5.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new System.Drawing.Point(12, 17);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(45, 18);
            labelControl5.TabIndex = 17;
            labelControl5.Text = "Marka:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(237, 20);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(43, 18);
            labelControl1.TabIndex = 18;
            labelControl1.Text = "Model:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(12, 55);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(48, 18);
            labelControl2.TabIndex = 19;
            labelControl2.Text = "%KDV:";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(236, 55);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(33, 18);
            labelControl3.TabIndex = 20;
            labelControl3.Text = "Stok:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl4.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new System.Drawing.Point(12, 91);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(61, 18);
            labelControl4.TabIndex = 21;
            labelControl4.Text = "Alış Fiyat:";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl6.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Appearance.Options.UseForeColor = true;
            labelControl6.Location = new System.Drawing.Point(226, 93);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(71, 18);
            labelControl6.TabIndex = 22;
            labelControl6.Text = "Satış Fiyat:";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl7.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Appearance.Options.UseForeColor = true;
            labelControl7.Location = new System.Drawing.Point(121, 125);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(69, 18);
            labelControl7.TabIndex = 23;
            labelControl7.Text = "Üretim Yılı:";
            // 
            // StokEkleForm
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(21, 22, 23);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(448, 205);
            Controls.Add(labelControl7);
            Controls.Add(labelControl6);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(labelControl5);
            Controls.Add(txtUretimYili);
            Controls.Add(txtAlis);
            Controls.Add(txtSatis);
            Controls.Add(txtStokSayisi);
            Controls.Add(txtKdv);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(simpleButton1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "StokEkleForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StokEkleForm";
            Load += StokEkleForm_Load;
            ((System.ComponentModel.ISupportInitialize)txtMarka.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtModel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKdv.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStokSayisi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSatis.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAlis.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUretimYili.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.TextEdit txtKdv;
        private DevExpress.XtraEditors.TextEdit txtStokSayisi;
        private DevExpress.XtraEditors.TextEdit txtSatis;
        private DevExpress.XtraEditors.TextEdit txtAlis;
        private DevExpress.XtraEditors.TextEdit txtUretimYili;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}