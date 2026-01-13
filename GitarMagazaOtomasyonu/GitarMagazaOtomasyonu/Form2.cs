using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitarMagazaOtomasyonu
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public string SecilenSohbetJson { get; set; }
        
        string connectionString = @"Server=DESKTOP-2O9O96Q\SQLEXPRESS;Database=GecmisSohbet;Trusted_Connection=True;";

        public Form2()
        {
            InitializeComponent();
            simpleButton1.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            simpleButton1.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60); // Hafifçe açılan gri (parlama hissi)

            // 2. Üzerine gelince yazı rengini daha parlak bir turuncu yap
            simpleButton1.AppearanceHovered.Options.UseForeColor = true;
            simpleButton1.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0); // Daha canlı turuncu

            // 3. İsteğe bağlı: Üzerine gelince turuncu ince bir çerçeve çıksın (parlama efekti)
            simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton1.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");
            this.ShowIcon = false;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
        }

       
        private async void Form2_Load(object sender, EventArgs e)
        {
            await VerileriYukleAsync();
            simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            simpleButton1.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            simpleButton1.Appearance.BorderColor = Color.FromArgb(45, 45, 48);

            // 1. Temayı devre dışı bırakıp düz (flat) stile geçiyoruz
            simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            // 2. Buton stilini 'Simple' yaparak çerçeveyi görünür kılıyoruz
            simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            // 3. Çerçeve rengini senin turuncuna (#FF8C00) boyuyoruz
            simpleButton1.Appearance.Options.UseBorderColor = true;
            simpleButton1.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            // 4. (Opsiyonel) Mouse ile üzerine gelince çerçevenin beyaz parlamasını istersen:
            simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton1.AppearanceHovered.BorderColor = Color.White;
        }

        private async Task VerileriYukleAsync()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   
                    await conn.OpenAsync();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID, ilkmesaj, SohbetData, Tarih FROM Sohbetler ORDER BY Tarih DESC", conn);

                    
                    await Task.Run(() => da.Fill(dt));

                    gridControl1.DataSource = dt;

                    var view = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                    if (view != null)
                    {
                        if (view.Columns["ID"] != null) view.Columns["ID"].Visible = false;
                        if (view.Columns["SohbetData"] != null) view.Columns["SohbetData"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Bağlantı Hatası: " + ex.Message + "\nLütfen SQL Server'ın çalıştığından emin olun.");
                this.Close(); 
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            var view = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null && view.FocusedRowHandle >= 0)
            {
                SecilenSohbetJson = view.GetFocusedRowCellValue("SohbetData")?.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            var view = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            
            if (view != null && view.FocusedRowHandle >= 0)
            {
                
                object veri = view.GetFocusedRowCellValue("SohbetData");

                if (veri != null)
                {
                    SecilenSohbetJson = veri.ToString();

                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden yüklenecek bir sohbet seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}