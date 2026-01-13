namespace GitarMagazaOtomasyonu
{
    partial class kullaniciai
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
            rprSil = new DevExpress.XtraEditors.SimpleButton();
            ChatBot = new DevExpress.XtraEditors.MemoEdit();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            btnGonder = new DevExpress.XtraEditors.SimpleButton();
            btnDosyaSec = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)ChatBot.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // rprSil
            // 
            rprSil.Appearance.BackColor = System.Drawing.Color.Black;
            rprSil.Appearance.Options.UseBackColor = true;
            rprSil.Location = new System.Drawing.Point(12, 12);
            rprSil.Name = "rprSil";
            rprSil.Size = new System.Drawing.Size(79, 24);
            rprSil.TabIndex = 6;
            rprSil.Text = "Geri gel ↩️";
            rprSil.Click += rprSil_Click;
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
            ChatBot.Size = new System.Drawing.Size(744, 493);
            ChatBot.TabIndex = 12;
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new System.Drawing.Point(12, 541);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            memoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            memoEdit1.Properties.Appearance.Options.UseForeColor = true;
            memoEdit1.Properties.NullValuePrompt = "ChatBot mesajınızı bekliyor...";
            memoEdit1.Size = new System.Drawing.Size(544, 114);
            memoEdit1.TabIndex = 13;
            // 
            // btnGonder
            // 
            btnGonder.AllowFocus = false;
            btnGonder.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            btnGonder.Appearance.ForeColor = System.Drawing.Color.White;
            btnGonder.Appearance.Options.UseBackColor = true;
            btnGonder.Appearance.Options.UseForeColor = true;
            btnGonder.Location = new System.Drawing.Point(562, 541);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new System.Drawing.Size(155, 114);
            btnGonder.TabIndex = 14;
            btnGonder.Text = "⏎";
            btnGonder.Click += btnGonder_Click;
            // 
            // btnDosyaSec
            // 
            btnDosyaSec.Appearance.BackColor = System.Drawing.Color.FromArgb(29, 31, 33);
            btnDosyaSec.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            btnDosyaSec.Appearance.ForeColor = System.Drawing.Color.White;
            btnDosyaSec.Appearance.Options.UseBackColor = true;
            btnDosyaSec.Appearance.Options.UseFont = true;
            btnDosyaSec.Appearance.Options.UseForeColor = true;
            btnDosyaSec.Location = new System.Drawing.Point(723, 541);
            btnDosyaSec.Name = "btnDosyaSec";
            btnDosyaSec.Size = new System.Drawing.Size(33, 114);
            btnDosyaSec.TabIndex = 15;
            btnDosyaSec.Text = "📎";
            btnDosyaSec.Click += btnDosyaSec_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(127, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(276, 24);
            labelControl1.TabIndex = 16;
            labelControl1.Text = "GİTAR AI ANALİZ VE EĞİTMENİ";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(527, 12);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(229, 24);
            labelControl2.TabIndex = 17;
            labelControl2.Text = "Bağlantı Kuruldu 🤖: Aktif";
            // 
            // kullaniciai
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(21, 22, 23);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(768, 660);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(btnDosyaSec);
            Controls.Add(btnGonder);
            Controls.Add(memoEdit1);
            Controls.Add(ChatBot);
            Controls.Add(rprSil);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "kullaniciai";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "kullaniciai";
            FormClosing += kullaniciai_FormClosing;
            Load += kullaniciai_Load;
            ((System.ComponentModel.ISupportInitialize)ChatBot.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton rprSil;
        private DevExpress.XtraEditors.MemoEdit ChatBot;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.SimpleButton btnDosyaSec;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}