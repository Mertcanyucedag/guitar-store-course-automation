namespace GitarMagazaOtomasyonu
{
    partial class StokSayfasi
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
            components = new System.ComponentModel.Container();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            btnStokUyari = new DevExpress.XtraEditors.SimpleButton();
            timer1 = new System.Windows.Forms.Timer(components);
            StokG = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // labelControl4
            // 
            labelControl4.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new System.Drawing.Point(599, 632);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(149, 16);
            labelControl4.TabIndex = 4;
            labelControl4.Text = "© 2025 Gitar Tamir Kursu";
            labelControl4.Click += labelControl4_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = System.Drawing.Color.Black;
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Location = new System.Drawing.Point(12, 12);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(79, 24);
            simpleButton2.TabIndex = 5;
            simpleButton2.Text = "Geri gel ↩️";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = System.Drawing.Color.Black;
            simpleButton1.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseBorderColor = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.Location = new System.Drawing.Point(31, 54);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(118, 36);
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Yeni Ürün ekle";
            simpleButton1.Click += simpleButton1_Click_1;
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(31, 107);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(717, 466);
            gridControl1.TabIndex = 7;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DarkGray;
            gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            gridView1.Appearance.Row.ForeColor = System.Drawing.Color.White;
            gridView1.Appearance.Row.Options.UseBackColor = true;
            gridView1.Appearance.Row.Options.UseForeColor = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.RowStyle += gridView1_RowStyle;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.BackColor = System.Drawing.Color.Black;
            simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            simpleButton3.Appearance.Options.UseBackColor = true;
            simpleButton3.Appearance.Options.UseForeColor = true;
            simpleButton3.Location = new System.Drawing.Point(630, 54);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new System.Drawing.Size(118, 36);
            simpleButton3.TabIndex = 8;
            simpleButton3.Text = "Seçili Satırı Sil";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // btnStokUyari
            // 
            btnStokUyari.AllowFocus = false;
            btnStokUyari.Appearance.BackColor = System.Drawing.Color.DarkRed;
            btnStokUyari.Appearance.ForeColor = System.Drawing.Color.Black;
            btnStokUyari.Appearance.Options.UseBackColor = true;
            btnStokUyari.Appearance.Options.UseForeColor = true;
            btnStokUyari.Location = new System.Drawing.Point(537, 584);
            btnStokUyari.Name = "btnStokUyari";
            btnStokUyari.Size = new System.Drawing.Size(211, 36);
            btnStokUyari.TabIndex = 9;
            btnStokUyari.Text = "simpleButton4";
            btnStokUyari.Visible = false;
            btnStokUyari.Click += btnStokUyari_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // StokG
            // 
            StokG.Appearance.BackColor = System.Drawing.Color.Black;
            StokG.Appearance.Options.UseBackColor = true;
            StokG.Location = new System.Drawing.Point(463, 54);
            StokG.Name = "StokG";
            StokG.Size = new System.Drawing.Size(145, 36);
            StokG.TabIndex = 10;
            StokG.Text = "Stoğunu Güncelle";
            StokG.Click += StokG_Click;
            // 
            // StokSayfasi
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(21, 22, 23);
            Appearance.Options.UseBackColor = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            ClientSize = new System.Drawing.Size(768, 660);
            Controls.Add(StokG);
            Controls.Add(btnStokUyari);
            Controls.Add(simpleButton3);
            Controls.Add(gridControl1);
            Controls.Add(simpleButton1);
            Controls.Add(simpleButton2);
            Controls.Add(labelControl4);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "StokSayfasi";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Otomasyon";
            FormClosing += StokSayfasi_FormClosing;
            Load += StokSayfasi_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnStokUyari;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton StokG;
    }
}