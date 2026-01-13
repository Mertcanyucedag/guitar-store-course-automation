
namespace GitarMagazaOtomasyonu
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
            txtKullanici = new DevExpress.XtraEditors.TextEdit();
            txtSifre = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtKullanici.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new System.Drawing.Point(285, 109);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new System.Drawing.Size(340, 22);
            txtKullanici.TabIndex = 0;
            txtKullanici.EditValueChanged += txtKullanici_EditValueChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new System.Drawing.Point(285, 174);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new System.Drawing.Size(340, 22);
            txtSifre.TabIndex = 2;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(86, 98);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(176, 33);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Kullanıcı Adı:";
            labelControl1.Click += labelControl1_Click;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(30, 9);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(652, 52);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Gitar Tamir-Kurs Otomasyonu";
            labelControl2.Click += labelControw_Click;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(189, 165);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(73, 33);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Şifre:";
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.Controls.Add(txtSifre);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(txtKullanici);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(simpleButton1);
            panelControl1.Location = new System.Drawing.Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(739, 331);
            panelControl1.TabIndex = 6;
            panelControl1.Paint += panelControl1_Paint_1;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            simpleButton1.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.Location = new System.Drawing.Point(285, 225);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(187, 77);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "Giriş yap";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // Form1
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            Appearance.ForeColor = System.Drawing.Color.Black;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(768, 355);
            Controls.Add(panelControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            HelpButton = true;
            HtmlText = "Otomasyon";
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtKullanici.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

