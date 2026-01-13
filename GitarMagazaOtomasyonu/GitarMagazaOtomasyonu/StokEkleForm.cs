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
    public partial class StokEkleForm : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2O9O96Q\SQLEXPRESS;Initial Catalog=StokControl;Integrated Security=True");
        public StokEkleForm()
        {
            InitializeComponent();
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
        }

        private void StokEkleForm_Load(object sender, EventArgs e)
        {
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // Tablo adını TBL_STOKLARR (iki R) yaptık:
                SqlCommand komut = new SqlCommand("INSERT INTO TBL_STOKLARR (MARKA, MODEL, URETIMYILI, STOKSAYISI, ALISFIYAT, SATISFIYAT, YUZDEKDVORAN) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglanti);

                komut.Parameters.AddWithValue("@p1", txtMarka.Text);
                komut.Parameters.AddWithValue("@p2", txtModel.Text);
                komut.Parameters.AddWithValue("@p3", int.Parse(txtUretimYili.Text));
                komut.Parameters.AddWithValue("@p4", int.Parse(txtStokSayisi.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(txtAlis.Text));
                komut.Parameters.AddWithValue("@p6", decimal.Parse(txtSatis.Text));
                komut.Parameters.AddWithValue("@p7", int.Parse(txtKdv.Text));

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün başarıyla kaydedildi!", "Sistem Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Pencereyi kapatır
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
