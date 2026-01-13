namespace GitarMagazaOtomasyonu
{
    partial class kullanicistok
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(12, 37);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(732, 388);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gray;
            gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            gridView1.Appearance.Row.ForeColor = System.Drawing.Color.White;
            gridView1.Appearance.Row.Options.UseBackColor = true;
            gridView1.Appearance.Row.Options.UseForeColor = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = System.Drawing.Color.Black;
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Location = new System.Drawing.Point(12, 7);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(79, 24);
            simpleButton2.TabIndex = 6;
            simpleButton2.Text = "Geri gel ↩️";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // kullanicistok
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(21, 22, 23);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(768, 437);
            Controls.Add(simpleButton2);
            Controls.Add(gridControl1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "kullanicistok";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "kullanicistok";
            FormClosing += kullanicistok_FormClosing;
            Load += kullanicistok_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}