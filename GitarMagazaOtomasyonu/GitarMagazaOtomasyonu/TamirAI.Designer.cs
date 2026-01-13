namespace GitarMagazaOtomasyonu
{
    partial class TamirAI
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
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            rprSil = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            rprEkle = new DevExpress.XtraEditors.SimpleButton();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            btnGonder = new DevExpress.XtraEditors.SimpleButton();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ChatBot = new DevExpress.XtraEditors.MemoEdit();
            gecmissohbetgör = new DevExpress.XtraEditors.SimpleButton();
            btnDosyaSec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChatBot.Properties).BeginInit();
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
            // 
            // rprSil
            // 
            rprSil.Appearance.BackColor = System.Drawing.Color.Black;
            rprSil.Appearance.Options.UseBackColor = true;
            rprSil.Location = new System.Drawing.Point(12, 12);
            rprSil.Name = "rprSil";
            rprSil.Size = new System.Drawing.Size(79, 24);
            rprSil.TabIndex = 5;
            rprSil.Text = "Geri gel ↩️";
            rprSil.Click += simpleButton2_Click;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.Location = new System.Drawing.Point(12, 519);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(315, 96);
            panelControl1.TabIndex = 6;
            panelControl1.Paint += panelControl1_Paint;
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new System.Drawing.Point(12, 521);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            memoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            memoEdit1.Properties.Appearance.Options.UseForeColor = true;
            memoEdit1.Properties.NullValuePrompt = "ChatBot mesajınızı bekliyor...";
            memoEdit1.Size = new System.Drawing.Size(234, 91);
            memoEdit1.TabIndex = 12;
            memoEdit1.EditValueChanged += memoEdit1_EditValueChanged;
            // 
            // panelControl2
            // 
            panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panelControl2.Appearance.Options.UseBackColor = true;
            panelControl2.Controls.Add(gridControl1);
            panelControl2.Controls.Add(rprEkle);
            panelControl2.Controls.Add(simpleButton4);
            panelControl2.Location = new System.Drawing.Point(336, 42);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(421, 573);
            panelControl2.TabIndex = 7;
            panelControl2.Paint += panelControl2_Paint;
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(5, 43);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(411, 525);
            gridControl1.TabIndex = 15;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.DoubleClick += gridControl1_DoubleClick;
            // 
            // gridView1
            // 
            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gray;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            gridView1.Appearance.Row.ForeColor = System.Drawing.Color.White;
            gridView1.Appearance.Row.Options.UseBackColor = true;
            gridView1.Appearance.Row.Options.UseForeColor = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // rprEkle
            // 
            rprEkle.AllowFocus = false;
            rprEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            rprEkle.Appearance.ForeColor = System.Drawing.Color.White;
            rprEkle.Appearance.Options.UseBackColor = true;
            rprEkle.Appearance.Options.UseForeColor = true;
            rprEkle.Location = new System.Drawing.Point(331, 4);
            rprEkle.Name = "rprEkle";
            rprEkle.Size = new System.Drawing.Size(85, 33);
            rprEkle.TabIndex = 13;
            rprEkle.Text = "Yeni Rapor";
            rprEkle.Click += rprEkle_Click;
            // 
            // simpleButton4
            // 
            simpleButton4.AllowFocus = false;
            simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            simpleButton4.Appearance.ForeColor = System.Drawing.Color.White;
            simpleButton4.Appearance.Options.UseBackColor = true;
            simpleButton4.Appearance.Options.UseForeColor = true;
            simpleButton4.Location = new System.Drawing.Point(4, 4);
            simpleButton4.Name = "simpleButton4";
            simpleButton4.Size = new System.Drawing.Size(85, 33);
            simpleButton4.TabIndex = 14;
            simpleButton4.Text = "Rapor Sil";
            simpleButton4.Click += simpleButton4_Click;
            // 
            // separatorControl1
            // 
            separatorControl1.AutoSizeMode = true;
            separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            separatorControl1.Location = new System.Drawing.Point(318, 34);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Size = new System.Drawing.Size(19, 591);
            separatorControl1.TabIndex = 8;
            // 
            // btnGonder
            // 
            btnGonder.AllowFocus = false;
            btnGonder.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            btnGonder.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            btnGonder.Appearance.Options.UseBackColor = true;
            btnGonder.Appearance.Options.UseForeColor = true;
            btnGonder.Location = new System.Drawing.Point(248, 521);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new System.Drawing.Size(41, 91);
            btnGonder.TabIndex = 9;
            btnGonder.Text = "⏎";
            btnGonder.Click += simpleButton1_Click;
            // 
            // panelControl3
            // 
            panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            panelControl3.Appearance.Options.UseBackColor = true;
            panelControl3.Location = new System.Drawing.Point(12, 42);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new System.Drawing.Size(280, 471);
            panelControl3.TabIndex = 10;
            panelControl3.Paint += panelControl3_Paint;
            // 
            // ChatBot
            // 
            ChatBot.Location = new System.Drawing.Point(12, 42);
            ChatBot.Name = "ChatBot";
            ChatBot.Properties.AllowFocused = false;
            ChatBot.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            ChatBot.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            ChatBot.Properties.Appearance.Options.UseBackColor = true;
            ChatBot.Properties.Appearance.Options.UseForeColor = true;
            ChatBot.Properties.NullValuePrompt = "ChatBot yanıtı burada gözükecek...";
            ChatBot.Properties.ReadOnly = true;
            ChatBot.Size = new System.Drawing.Size(315, 473);
            ChatBot.TabIndex = 11;
            ChatBot.EditValueChanged += memoEdit3_EditValueChanged;
            // 
            // gecmissohbetgör
            // 
            gecmissohbetgör.Appearance.BackColor = System.Drawing.Color.Black;
            gecmissohbetgör.Appearance.ForeColor = System.Drawing.Color.White;
            gecmissohbetgör.Appearance.Options.UseBackColor = true;
            gecmissohbetgör.Appearance.Options.UseForeColor = true;
            gecmissohbetgör.Location = new System.Drawing.Point(128, 12);
            gecmissohbetgör.Name = "gecmissohbetgör";
            gecmissohbetgör.Size = new System.Drawing.Size(143, 24);
            gecmissohbetgör.TabIndex = 13;
            gecmissohbetgör.Text = "Geçmiş Sohbetler";
            gecmissohbetgör.Click += gecmissohbetgör_Click;
            // 
            // btnDosyaSec
            // 
            btnDosyaSec.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            btnDosyaSec.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            btnDosyaSec.Appearance.ForeColor = System.Drawing.Color.White;
            btnDosyaSec.Appearance.Options.UseBackColor = true;
            btnDosyaSec.Appearance.Options.UseFont = true;
            btnDosyaSec.Appearance.Options.UseForeColor = true;
            btnDosyaSec.Location = new System.Drawing.Point(295, 521);
            btnDosyaSec.Name = "btnDosyaSec";
            btnDosyaSec.Size = new System.Drawing.Size(18, 91);
            btnDosyaSec.TabIndex = 14;
            btnDosyaSec.Text = "📎";
            btnDosyaSec.Click += btnDosyaSec_Click;
            // 
            // TamirAI
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(21, 22, 23);
            Appearance.Options.UseBackColor = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(768, 660);
            Controls.Add(separatorControl1);
            Controls.Add(btnDosyaSec);
            Controls.Add(gecmissohbetgör);
            Controls.Add(memoEdit1);
            Controls.Add(ChatBot);
            Controls.Add(panelControl3);
            Controls.Add(btnGonder);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Controls.Add(rprSil);
            Controls.Add(labelControl4);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "TamirAI";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Otomasyon";
            FormClosing += TamirAI_FormClosing;
            Load += TamirAI_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChatBot.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton rprSil;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.MemoEdit ChatBot;
        private DevExpress.XtraEditors.SimpleButton rprEkle;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton gecmissohbetgör;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnDosyaSec;
    }
}