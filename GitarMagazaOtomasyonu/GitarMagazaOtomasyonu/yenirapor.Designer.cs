namespace GitarMagazaOtomasyonu
{
    partial class yenirapor
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
            txtMusteriAdSoyad = new DevExpress.XtraEditors.TextEdit();
            cmbCozumDurumu = new DevExpress.XtraEditors.ComboBoxEdit();
            memoYapilanIslemler = new DevExpress.XtraEditors.MemoEdit();
            picGitarFotograf = new DevExpress.XtraEditors.PictureEdit();
            btnFotografSec = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            txtGitarProblem = new System.Windows.Forms.ComboBox();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtMusteriAdSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCozumDurumu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoYapilanIslemler.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGitarFotograf.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMusteriAdSoyad
            // 
            txtMusteriAdSoyad.Location = new System.Drawing.Point(135, 33);
            txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            txtMusteriAdSoyad.Size = new System.Drawing.Size(156, 22);
            txtMusteriAdSoyad.TabIndex = 0;
            // 
            // cmbCozumDurumu
            // 
            cmbCozumDurumu.Location = new System.Drawing.Point(121, 92);
            cmbCozumDurumu.Name = "cmbCozumDurumu";
            cmbCozumDurumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbCozumDurumu.Size = new System.Drawing.Size(156, 22);
            cmbCozumDurumu.TabIndex = 2;
            cmbCozumDurumu.SelectedIndexChanged += cmbCozumDurumu_SelectedIndexChanged;
            // 
            // memoYapilanIslemler
            // 
            memoYapilanIslemler.Location = new System.Drawing.Point(131, 173);
            memoYapilanIslemler.Name = "memoYapilanIslemler";
            memoYapilanIslemler.Size = new System.Drawing.Size(157, 120);
            memoYapilanIslemler.TabIndex = 3;
            // 
            // picGitarFotograf
            // 
            picGitarFotograf.Location = new System.Drawing.Point(314, 83);
            picGitarFotograf.Name = "picGitarFotograf";
            picGitarFotograf.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            picGitarFotograf.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            picGitarFotograf.Size = new System.Drawing.Size(265, 221);
            picGitarFotograf.TabIndex = 4;
            // 
            // btnFotografSec
            // 
            btnFotografSec.Appearance.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnFotografSec.Appearance.ForeColor = System.Drawing.Color.White;
            btnFotografSec.Appearance.Options.UseBackColor = true;
            btnFotografSec.Appearance.Options.UseForeColor = true;
            btnFotografSec.Location = new System.Drawing.Point(397, 298);
            btnFotografSec.Name = "btnFotografSec";
            btnFotografSec.Size = new System.Drawing.Size(84, 36);
            btnFotografSec.TabIndex = 5;
            btnFotografSec.Text = "Fotoğraf Seç";
            btnFotografSec.Click += btnFotografSec_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            btnKaydet.Appearance.Options.UseBackColor = true;
            btnKaydet.Appearance.Options.UseForeColor = true;
            btnKaydet.Location = new System.Drawing.Point(260, 347);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(66, 43);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(txtGitarProblem);
            panelControl1.Controls.Add(btnFotografSec);
            panelControl1.Controls.Add(btnKaydet);
            panelControl1.Controls.Add(labelControl4);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(cmbCozumDurumu);
            panelControl1.Location = new System.Drawing.Point(10, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(576, 406);
            panelControl1.TabIndex = 11;
            panelControl1.Paint += panelControl1_Paint;
            // 
            // txtGitarProblem
            // 
            txtGitarProblem.FormattingEnabled = true;
            txtGitarProblem.Location = new System.Drawing.Point(403, 24);
            txtGitarProblem.Name = "txtGitarProblem";
            txtGitarProblem.Size = new System.Drawing.Size(151, 24);
            txtGitarProblem.TabIndex = 7;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl4.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new System.Drawing.Point(75, 211);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(33, 18);
            labelControl4.TabIndex = 4;
            labelControl4.Text = "Not :";
            labelControl4.Click += labelControl4_Click;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(5, 96);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(110, 18);
            labelControl3.TabIndex = 3;
            labelControl3.Text = "Mevcut durum : ";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(288, 24);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(109, 18);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Gitarın Problemi :";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(31, 24);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(77, 18);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Ad-Soyad : ";
            // 
            // yenirapor
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(21, 22, 23);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(600, 430);
            Controls.Add(picGitarFotograf);
            Controls.Add(memoYapilanIslemler);
            Controls.Add(txtMusteriAdSoyad);
            Controls.Add(panelControl1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "yenirapor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Yeni Rapor Ekle";
            Load += yenirapor_Load;
            ((System.ComponentModel.ISupportInitialize)txtMusteriAdSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCozumDurumu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoYapilanIslemler.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGitarFotograf.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMusteriAdSoyad;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCozumDurumu;
        private DevExpress.XtraEditors.MemoEdit memoYapilanIslemler;
        private DevExpress.XtraEditors.PictureEdit picGitarFotograf;
        private DevExpress.XtraEditors.SimpleButton btnFotografSec;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox txtGitarProblem;
    }
}