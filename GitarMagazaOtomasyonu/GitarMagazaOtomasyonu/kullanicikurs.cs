using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitarMagazaOtomasyonu
{
    public partial class kullanicikurs : DevExpress.XtraEditors.XtraForm
    {
        private void Listele()
        {
            // Bağlantı adresini kendi Desktop yoluna göre güncelle
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2O9O96Q\SQLEXPRESS;Initial Catalog=GitarMagazaDB;Integrated Security=True");

            try
            {
                // Tablodaki her şeyi olduğu gibi çekiyoruz
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_1", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Veriyi GridControl'e bağlıyoruz
                gridControl1.DataSource = dt;

                // --- Görünüm Ayarları ---
                // Kullanıcının tablo üzerinde elle değişiklik yapmasını (silme/yazma) engelle
                gridView1.OptionsBehavior.Editable = false;

                // Sütun başlıklarını güzelleştirelim
                gridView1.Columns[0].Caption = "GÜNLER / SAATLER";

                // Sütun genişliklerini içeriğe göre otomatik ayarla
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders programı yüklenirken hata oluştu: " + ex.Message);
            }
        }
        public kullanicikurs()
        {
            InitializeComponent();
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
        }

        private void kullanicikurs_Load(object sender, EventArgs e)
        {
            Listele();
            simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            simpleButton1.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            simpleButton1.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            simpleButton1.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            simpleButton1.AppearanceHovered.Options.UseForeColor = true;
            simpleButton1.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0); 
            simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton1.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");
            simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            simpleButton1.Appearance.Options.UseBorderColor = true;
            simpleButton1.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");
            simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton1.AppearanceHovered.BorderColor = Color.White;
        }

        private void kullanicikurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AnaSayfa frmGiris = new AnaSayfa();
            frmGiris.Show();
            this.Dispose();
        }
    }
}
