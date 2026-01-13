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
    public partial class StokSayfasi : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2O9O96Q\SQLEXPRESS;Initial Catalog=StokControl;Integrated Security=True");
        string secilenID;
        void Listele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // Tablo ismin: TBL_STOKLARR
                // Listele metodundaki sorguyu şu şekilde sadeleştirerek dene:
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, MARKA, MODEL, URETIMYILI, STOKSAYISI, ALISFIYAT, SATISFIYAT, YUZDEKDVORAN FROM TBL_STOKLARR", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridControl1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }

        }
        void UyariKontrol()
        {
            int adet = KritikStokSayisi();
            if (adet > 0)
            {
                btnStokUyari.Visible = true;
                btnStokUyari.Text = "DİKKAT: " + adet + " Ürün Stokta Bitti!";
                timer1.Start(); // Yanıp sönmeyi başlat
            }
            else
            {
                btnStokUyari.Visible = false;
                timer1.Stop(); // Her şey tamamsa durdur
            }
        }
        public StokSayfasi()
        {
            InitializeComponent();
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
        }

        private void StokSayfasi_Load(object sender, EventArgs e)
        {
            Listele();
            UyariKontrol();
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

            simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            simpleButton2.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            simpleButton2.Appearance.Options.UseForeColor = true;
            simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            simpleButton2.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            simpleButton2.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            simpleButton2.AppearanceHovered.Options.UseForeColor = true;
            simpleButton2.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton2.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            simpleButton3.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            simpleButton3.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            simpleButton3.Appearance.Options.UseForeColor = true;
            simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            simpleButton3.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            simpleButton3.AppearanceHovered.Options.UseBackColor = true;
            simpleButton3.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            simpleButton3.AppearanceHovered.Options.UseForeColor = true;
            simpleButton3.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            simpleButton3.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton3.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            StokG.LookAndFeel.UseDefaultLookAndFeel = false;
            StokG.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            StokG.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            StokG.Appearance.Options.UseForeColor = true;
            StokG.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            StokG.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            StokG.AppearanceHovered.Options.UseBackColor = true;
            StokG.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            StokG.AppearanceHovered.Options.UseForeColor = true;
            StokG.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            StokG.AppearanceHovered.Options.UseBorderColor = true;
            StokG.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");
        }

        private void StokSayfasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AnaSayfa frmGiris = new AnaSayfa();
            frmGiris.Show();

            // Bu (AnaSayfa) formu kapatıyoruz
            this.Dispose(); // Hafızadan tamamen temizler
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AnaSayfa frmGiris = new AnaSayfa();
            frmGiris.Show();

            // Bu (AnaSayfa) formu kapatıyoruz
            this.Dispose(); // Hafızadan tamamen temizler
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            StokEkleForm frm = new StokEkleForm();
            // Bu pencere kapanana kadar ana pencereye dokunulmaz:
            frm.ShowDialog();

            // Pencere kapandığında ana sayfadaki tabloyu güncellemesi için:
            Listele();
            UyariKontrol();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                // SQL'deki "ID" sütunundaki değeri al ve yukarıda tanımladığımız secilenID'ye ata
                secilenID = dr["ID"].ToString();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secilenID))
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                Listele();
                UyariKontrol();
            }

            // 2. Kullanıcıdan onay alıyoruz
            DialogResult onay = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz? Bu işlem geri alınamaz.", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                    // 3. SQL DELETE komutunu hazırlıyoruz
                    SqlCommand komutSil = new SqlCommand("DELETE FROM TBL_STOKLARR WHERE ID=@p1", baglanti);
                    komutSil.Parameters.AddWithValue("@p1", secilenID);

                    komutSil.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Tabloyu güncelliyoruz ki silinen ürün gitsin
                    Listele();

                    // 5. Silinen ID'yi temizliyoruz ki tekrar basınca eski ID ile işlem yapmasın
                    secilenID = "";
                }
                catch (Exception ex)
                {
                    if (baglanti.State == ConnectionState.Open) baglanti.Close();
                    MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message);
                }
            }
            UyariKontrol();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                // Grid'deki STOKSAYISI hücresindeki değeri alıyoruz
                object stok = gridView1.GetRowCellValue(e.RowHandle, "STOKSAYISI");

                // Eğer değer null değilse ve 0'a eşitse
                if (stok != null && Convert.ToInt32(stok) == 0)
                {
                    // Satırın arka planını ve yazı rengini ayarlıyoruz
                    e.Appearance.BackColor = Color.Salmon; // Kırmızımsı bir renk
                    e.Appearance.ForeColor = Color.White;  // Beyaz yazı
                    e.HighPriority = true; // Temanın bu rengi ezmesini engeller
                }
            }
        }
        int KritikStokSayisi()
        {
            int sayi = 0;
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                // Stok sayısı 0 olanları sayan SQL sorgusu
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBL_STOKLARR WHERE STOKSAYISI = 0", baglanti);
                sayi = (int)komut.ExecuteScalar();
                baglanti.Close();
            }
            catch (Exception) { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
            return sayi;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Butonun rengini her yarım saniyede bir değiştirerek yanıp sönme efekti veriyoruz
            if (btnStokUyari.Appearance.BackColor == Color.DarkRed)
            {
                btnStokUyari.Appearance.BackColor = Color.Red;
                btnStokUyari.ForeColor = Color.White;
            }
            else
            {
                btnStokUyari.Appearance.BackColor = Color.DarkRed;
                btnStokUyari.ForeColor = Color.Yellow; // Dikkat çekmesi için sarı yazı
            }
        }

        private void btnStokUyari_Click(object sender, EventArgs e)
        {

        }

        private void StokG_Click(object sender, EventArgs e)
        {
            StokGForm frm = new StokGForm();
            frm.ShowDialog(); 

            Listele(); 
            UyariKontrol();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
    }
}
