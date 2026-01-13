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
    public partial class StokGForm : DevExpress.XtraEditors.XtraForm
    {
        public string urunID;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2O9O96Q\SQLEXPRESS;Initial Catalog=StokControl;Integrated Security=True");
        public StokGForm()
        {
            InitializeComponent();
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
        }

        private void StokGForm_Load(object sender, EventArgs e)
        {
            btnGuncelle.LookAndFeel.UseDefaultLookAndFeel = false;
            btnGuncelle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            btnGuncelle.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            btnGuncelle.Appearance.Options.UseForeColor = true;
            btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnGuncelle.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGuncelle.AppearanceHovered.Options.UseBackColor = true;
            btnGuncelle.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            btnGuncelle.AppearanceHovered.Options.UseForeColor = true;
            btnGuncelle.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            btnGuncelle.AppearanceHovered.Options.UseBorderColor = true;
            btnGuncelle.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");


            // 1. Temayı devre dışı bırakıp düz (flat) stile geçiyoruz
            btnGuncelle.LookAndFeel.UseDefaultLookAndFeel = false;
            btnGuncelle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            // 2. Buton stilini 'Simple' yaparak çerçeveyi görünür kılıyoruz
            btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            // 3. Çerçeve rengini senin turuncuna (#FF8C00) boyuyoruz
            btnGuncelle.Appearance.Options.UseBorderColor = true;
            btnGuncelle.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            // 4. (Opsiyonel) Mouse ile üzerine gelince çerçevenin beyaz parlamasını istersen:
            btnGuncelle.AppearanceHovered.Options.UseBorderColor = true;
            btnGuncelle.AppearanceHovered.BorderColor = Color.White;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // 1. Boş kutu kontrolü
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtAdet.Text))
            {
                MessageBox.Show("Lütfen hem ID numarasını hem de eklenecek miktarı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // 2. SQL UPDATE sorgusu
                // Kullanıcının elle yazdığı txtID.Text değerine göre STOKSAYISI artırılır
                SqlCommand komut = new SqlCommand("UPDATE TBL_STOKLARR SET STOKSAYISI = STOKSAYISI + @p1 WHERE ID = @p2", baglanti);

                komut.Parameters.AddWithValue("@p1", int.Parse(txtAdet.Text)); // Eklenecek adet
                komut.Parameters.AddWithValue("@p2", txtID.Text);              // Elle yazılan ID

                int sonuc = komut.ExecuteNonQuery();

                baglanti.Close();

                // 3. Geçersiz ID kontrolü
                if (sonuc > 0)
                {
                    MessageBox.Show(txtID.Text + " ID'li ürünün stoğu başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Başarılıysa formu kapat
                }
                else
                {
                    MessageBox.Show("Yazdığınız ID numarasına ait bir ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("İşlem başarısız: " + ex.Message);
            }
        }
    }
}
