namespace GitarMagazaOtomasyonu
{
    partial class StokGForm
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
            btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            txtID = new DevExpress.XtraEditors.TextEdit();
            txtAdet = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdet.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Appearance.BackColor = System.Drawing.Color.Black;
            btnGuncelle.Appearance.Options.UseBackColor = true;
            btnGuncelle.Location = new System.Drawing.Point(146, 112);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new System.Drawing.Size(126, 29);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(339, 38);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(76, 22);
            txtID.TabIndex = 1;
            // 
            // txtAdet
            // 
            txtAdet.Location = new System.Drawing.Point(339, 74);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new System.Drawing.Size(76, 22);
            txtAdet.TabIndex = 2;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(12, 39);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(300, 18);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Stok Girmek İstediğiğiniz Ürünün ID Numarası:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(171, 75);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(141, 18);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Eklenecek Stok Sayısı:";
            // 
            // StokGForm
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(21, 22, 23);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(448, 160);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(txtAdet);
            Controls.Add(txtID);
            Controls.Add(btnGuncelle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "StokGForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Stok Güncelle Form";
            Load += StokGForm_Load;
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdet.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtAdet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}