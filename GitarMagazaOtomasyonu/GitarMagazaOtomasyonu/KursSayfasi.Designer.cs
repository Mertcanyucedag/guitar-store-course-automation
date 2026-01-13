namespace GitarMagazaOtomasyonu
{
    partial class KursSayfasi
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
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            cmbOdeme = new DevExpress.XtraEditors.ComboBoxEdit();
            txtModel = new DevExpress.XtraEditors.TextEdit();
            txtAd = new DevExpress.XtraEditors.TextEdit();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOdeme.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtModel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // separatorControl1
            // 
            separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            separatorControl1.Location = new System.Drawing.Point(-20, 89);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Size = new System.Drawing.Size(832, 104);
            separatorControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(simpleButton1);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(cmbOdeme);
            panelControl1.Controls.Add(txtModel);
            panelControl1.Controls.Add(txtAd);
            panelControl1.Location = new System.Drawing.Point(12, 35);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(744, 95);
            panelControl1.TabIndex = 1;
            panelControl1.Paint += panelControl1_Paint;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = System.Drawing.Color.Black;
            simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.Location = new System.Drawing.Point(274, 66);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(159, 23);
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Gönder";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(504, 28);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(95, 16);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Ödeme Durumu:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(247, 28);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(70, 16);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Gitar Model:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(6, 28);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(59, 16);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Ad Soyad:";
            // 
            // cmbOdeme
            // 
            cmbOdeme.Location = new System.Drawing.Point(614, 25);
            cmbOdeme.Name = "cmbOdeme";
            cmbOdeme.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbOdeme.Properties.Items.AddRange(new object[] { "Ödendi", "Ödenmedi" });
            cmbOdeme.Size = new System.Drawing.Size(118, 22);
            cmbOdeme.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new System.Drawing.Point(330, 25);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(156, 22);
            txtModel.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new System.Drawing.Point(75, 25);
            txtAd.Name = "txtAd";
            txtAd.Size = new System.Drawing.Size(156, 22);
            txtAd.TabIndex = 0;
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(12, 159);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(744, 467);
            gridControl1.TabIndex = 2;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            // 
            // gridView1
            // 
            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
            gridView1.Appearance.Row.ForeColor = System.Drawing.Color.White;
            gridView1.Appearance.Row.Options.UseBackColor = true;
            gridView1.Appearance.Row.Options.UseBorderColor = true;
            gridView1.Appearance.Row.Options.UseForeColor = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new System.Drawing.Point(599, 632);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(149, 16);
            labelControl4.TabIndex = 3;
            labelControl4.Text = "© 2025 Gitar Tamir Kursu";
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = System.Drawing.Color.Black;
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Location = new System.Drawing.Point(12, 5);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(79, 24);
            simpleButton2.TabIndex = 4;
            simpleButton2.Text = "Geri gel ↩️";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // KursSayfasi
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(21, 22, 23);
            Appearance.ForeColor = System.Drawing.Color.Black;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(768, 660);
            Controls.Add(simpleButton2);
            Controls.Add(labelControl4);
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Controls.Add(separatorControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "KursSayfasi";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Otomasyon";
            FormClosing += KursSayfasi_FormClosing;
            Load += KursSayfasi_Load;
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOdeme.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtModel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.ComboBoxEdit cmbOdeme;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}