

using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GitarMagazaOtomasyonu
{
    public partial class TamirAI : DevExpress.XtraEditors.XtraForm
    {
        string secilenResimYolu = "";
        private void RaporlariYukle()
        {
            try
            {
                string conStr = @"Server=DESKTOP-2O9O96Q\SQLEXPRESS;Database=raporekle;Trusted_Connection=True;";
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    // Grid'i yormamak için fotoğrafı burada çekmiyoruz
                    string query = "SELECT ID, MusteriAdSoyad, GitarProblemi, CozumDurumu, KayitTarihi FROM GitarRaporlarii ORDER BY KayitTarihi DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gridControl1.DataSource = dt;

                    // Tasarım ayarları
                    var view = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                    if (view != null)
                    {
                        if (view.Columns["ID"] != null) view.Columns["ID"].Visible = false; // ID'yi gizle
                        view.BestFitColumns(); // Sütun genişliklerini otomatik ayarla
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Raporlar listelenirken hata oluştu: " + ex.Message);
            }
        }
        public void SohbetiEkranaYukle(string jsonVerisi)
        {

            try
            {
                // 1. Mevcut hafızayı ve ekranı temizle
                chatHistory.Clear();
                ChatBot.Text = "";

                // 2. Form2'den gelen JSON'ı tekrar listeye (hafızaya) çevir
                chatHistory = JsonConvert.DeserializeObject<List<object>>(jsonVerisi);

                // 3. Listeyi ekrana döngüyle yazdır
                foreach (dynamic item in chatHistory)
                {
                    string rol = item.role == "user" ? "SİZ" : "AI";
                    string metin = item.parts[0].text;

                    // Kullanıcıya mesajları göster
                    ChatBot.Text += $"{rol}: {metin}{Environment.NewLine}";
                    ChatBot.Text += "-----------------------------------" + Environment.NewLine;
                }

                // 4. İmleci en sona odakla ve aşağı kaydır
                ChatBot.SelectionStart = ChatBot.Text.Length;
                ChatBot.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sohbet yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private List<object> chatHistory = new List<object>();
        public TamirAI()
        {
            InitializeComponent();
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
        }
        private void TamirAI_Load(object sender, EventArgs e)
        {
            btnGonder.LookAndFeel.UseDefaultLookAndFeel = false;
            btnGonder.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            btnGonder.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            btnGonder.Appearance.Options.UseForeColor = true;
            btnGonder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnGonder.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGonder.AppearanceHovered.Options.UseBackColor = true;
            btnGonder.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            btnGonder.AppearanceHovered.Options.UseForeColor = true;
            btnGonder.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            btnGonder.AppearanceHovered.Options.UseBorderColor = true;
            btnGonder.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            btnDosyaSec.LookAndFeel.UseDefaultLookAndFeel = false;
            btnDosyaSec.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            btnDosyaSec.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            btnDosyaSec.Appearance.Options.UseForeColor = true;
            btnDosyaSec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnDosyaSec.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnDosyaSec.AppearanceHovered.Options.UseBackColor = true;
            btnDosyaSec.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            btnDosyaSec.AppearanceHovered.Options.UseForeColor = true;
            btnDosyaSec.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            btnDosyaSec.AppearanceHovered.Options.UseBorderColor = true;
            btnDosyaSec.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            rprEkle.LookAndFeel.UseDefaultLookAndFeel = false;
            rprEkle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            rprEkle.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            rprEkle.Appearance.Options.UseForeColor = true;
            rprEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            rprEkle.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            rprEkle.AppearanceHovered.Options.UseBackColor = true;
            rprEkle.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            rprEkle.AppearanceHovered.Options.UseForeColor = true;
            rprEkle.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            rprEkle.AppearanceHovered.Options.UseBorderColor = true;
            rprEkle.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            gecmissohbetgör.LookAndFeel.UseDefaultLookAndFeel = false;
            gecmissohbetgör.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            gecmissohbetgör.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            gecmissohbetgör.Appearance.Options.UseForeColor = true;
            gecmissohbetgör.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gecmissohbetgör.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            gecmissohbetgör.AppearanceHovered.Options.UseBackColor = true;
            gecmissohbetgör.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            gecmissohbetgör.AppearanceHovered.Options.UseForeColor = true;
            gecmissohbetgör.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            gecmissohbetgör.AppearanceHovered.Options.UseBorderColor = true;
            gecmissohbetgör.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            rprSil.LookAndFeel.UseDefaultLookAndFeel = false;
            rprSil.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            rprSil.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            rprSil.Appearance.Options.UseForeColor = true;
            rprSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            rprSil.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            rprSil.AppearanceHovered.Options.UseBackColor = true;
            rprSil.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            rprSil.AppearanceHovered.Options.UseForeColor = true;
            rprSil.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            rprSil.AppearanceHovered.Options.UseBorderColor = true;
            rprSil.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl1.Appearance.BackColor = Color.FromArgb(46, 46, 46);
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl2.Appearance.BackColor = Color.FromArgb(46, 46, 46);
            panelControl2.Appearance.Options.UseBackColor = true;
            panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl3.Appearance.BackColor = Color.FromArgb(46, 46, 46);
            panelControl3.Appearance.Options.UseBackColor = true;
            panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            RaporlariYukle();
            simpleButton4.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            simpleButton4.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            simpleButton4.Appearance.Options.UseForeColor = true;
            simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            simpleButton4.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            simpleButton4.AppearanceHovered.Options.UseBackColor = true;
            simpleButton4.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            simpleButton4.AppearanceHovered.Options.UseForeColor = true;
            simpleButton4.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            simpleButton4.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton4.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");


            
            rprSil.LookAndFeel.UseDefaultLookAndFeel = false;
            rprSil.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            
            rprSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            rprSil.Appearance.Options.UseBorderColor = true;
            rprSil.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

           
            rprSil.AppearanceHovered.Options.UseBorderColor = true;
            rprSil.AppearanceHovered.BorderColor = Color.White;



            rprEkle.LookAndFeel.UseDefaultLookAndFeel = false;
            rprEkle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

         
            rprEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            
            rprEkle.Appearance.Options.UseBorderColor = true;
            rprEkle.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            rprEkle.AppearanceHovered.Options.UseBorderColor = true;
            rprEkle.AppearanceHovered.BorderColor = Color.White;
          
            gecmissohbetgör.LookAndFeel.UseDefaultLookAndFeel = false;
            gecmissohbetgör.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

           
            gecmissohbetgör.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

      
            gecmissohbetgör.Appearance.Options.UseBorderColor = true;
            gecmissohbetgör.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            // 4. (Opsiyonel) Mouse ile üzerine gelince çerçevenin beyaz parlamasını istersen:
            gecmissohbetgör.AppearanceHovered.Options.UseBorderColor = true;
            gecmissohbetgör.AppearanceHovered.BorderColor = Color.White;

            //
            simpleButton4.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            // 2. Buton stilini 'Simple' yaparak çerçeveyi görünür kılıyoruz
            simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            // 3. Çerçeve rengini senin turuncuna (#FF8C00) boyuyoruz
            simpleButton4.Appearance.Options.UseBorderColor = true;
            simpleButton4.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            // 4. (Opsiyonel) Mouse ile üzerine gelince çerçevenin beyaz parlamasını istersen:
            simpleButton4.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton4.AppearanceHovered.BorderColor = Color.White;





            btnGonder.LookAndFeel.UseDefaultLookAndFeel = false;
            btnGonder.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            // 2. Buton stilini 'Simple' yaparak çerçeveyi görünür kılıyoruz
            btnGonder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            // 3. Çerçeve rengini senin turuncuna (#FF8C00) boyuyoruz
            btnGonder.Appearance.Options.UseBorderColor = true;
            btnGonder.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            // 4. (Opsiyonel) Mouse ile üzerine gelince çerçevenin beyaz parlamasını istersen:
            btnGonder.AppearanceHovered.Options.UseBorderColor = true;
            btnGonder.AppearanceHovered.BorderColor = Color.White;



            btnDosyaSec.LookAndFeel.UseDefaultLookAndFeel = false;
            btnDosyaSec.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            // 2. Buton stilini 'Simple' yaparak çerçeveyi görünür kılıyoruz
            btnDosyaSec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            // 3. Çerçeve rengini senin turuncuna (#FF8C00) boyuyoruz
            btnDosyaSec.Appearance.Options.UseBorderColor = true;
            btnDosyaSec.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            // 4. (Opsiyonel) Mouse ile üzerine gelince çerçevenin beyaz parlamasını istersen:
            btnDosyaSec.AppearanceHovered.Options.UseBorderColor = true;
            btnDosyaSec.AppearanceHovered.BorderColor = Color.White;
        }
        private void TamirAI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AnaSayfa frmGiris = new AnaSayfa();
            frmGiris.Show();
            this.Dispose();
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {
        }
        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(memoEdit1.Text))
                return;


            string hamMesaj = memoEdit1.Text;
            ChatBot.Text += $"SİZ: {hamMesaj}{Environment.NewLine}";


            string önmesaj = "Teknik ve kısa bir anlatım ile tıpkı bir Profesyonel Gitar Onarım uzmanı (Luthier) gibi cevapla ve * karakteri kullanmadan kullanıcıya doğrudan yansıtılacaktır unutma mesaj öz ve sanki bir luthiere öneri verir gibi olmaı, KISA OLMALI. çok uzatmadan anlatman gereken konu şu : ";
            string tamMesaj = önmesaj + hamMesaj;


            chatHistory.Add(new { role = "user", parts = new[] { new { text = tamMesaj } } });
            memoEdit1.Text = "";

            try
            {
                ChatBot.Text += "AI: Yanıt bekleniyor..." + Environment.NewLine;

                string apiKey = "YOUR_API_KEY";
                string requestUri = $"https://generativelanguage.googleapis.com/v1/models/gemini-2.5-flash:generateContent?key={apiKey}";


                var requestBody = new
                {
                    contents = chatHistory.ToArray()
                };

                string jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
                using var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                using var client = new HttpClient();

                var response = await client.PostAsync(requestUri, content);
                string responseString = await response.Content.ReadAsStringAsync();
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(responseString);

                if (result.candidates != null && result.candidates.Count > 0)
                {
                    string aiCevap = result.candidates[0].content.parts[0].text;


                    ChatBot.Text += $"AI: {aiCevap}{Environment.NewLine}";
                    ChatBot.Text += "-----------------------------------" + Environment.NewLine;
                    chatHistory.Add(new { role = "model", parts = new[] { new { text = aiCevap } } });


                    try
                    {

                        string conStr = @"Server=DESKTOP-2O9O96Q\SQLEXPRESS;Database=GecmisSohbet;Trusted_Connection=True;";

                        using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(conStr))
                        {
                            string query = "INSERT INTO Sohbetler (ilkmesaj, SohbetData, Tarih) VALUES (@p1, @p2, @p3)";
                            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn);

                            string baslik = hamMesaj.Length > 50 ? hamMesaj.Substring(0, 50) + "..." : hamMesaj;

                            cmd.Parameters.AddWithValue("@p1", baslik);
                            cmd.Parameters.AddWithValue("@p2", Newtonsoft.Json.JsonConvert.SerializeObject(chatHistory));
                            cmd.Parameters.AddWithValue("@p3", DateTime.Now);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception sqlEx)
                    {

                        System.Diagnostics.Debug.WriteLine("SQL Kayıt Hatası: " + sqlEx.Message);
                    }
                }
                else
                {
                    ChatBot.Text += "AI: Yanıt alınamadı." + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                ChatBot.Text += $"SİSTEM HATASI: {ex.Message}{Environment.NewLine}";
            }


            ChatBot.SelectionStart = ChatBot.Text.Length;
            ChatBot.ScrollToCaret();
        }


        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void memoEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gecmissohbetgör_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            // ShowDialog kullanmak en güvenlisidir
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(frm.SecilenSohbetJson))
                {
                    SohbetiEkranaYukle(frm.SecilenSohbetJson);
                }
            }
        }

        private void rprEkle_Click(object sender, EventArgs e)
        {
            // Yeni oluşturduğun formu örnekliyoruz
            yenirapor frm = new yenirapor();

            // Formu diyalog olarak açıyoruz (Bu sayede kullanıcı raporu bitirmeden ana ekrana tıklayamaz)
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Rapor kaydedilip OK sonucu döndüğünde sağdaki listeyi güncelleyeceğiz
                RaporlariYukle();
            }
            RaporlariYukle();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var view = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            // 2. Eğer bir satır seçiliyse (Handle 0 veya büyükse)
            if (view.FocusedRowHandle >= 0)
            {
                // Seçili satırdaki ID ve Müşteri ismini alalım
                int id = Convert.ToInt32(view.GetFocusedRowCellValue("ID"));
                string musteri = view.GetFocusedRowCellValue("MusteriAdSoyad").ToString();

                // 3. Kullanıcıya onay soralım (Yanlışlıkla silmeyi önlemek için)
                DialogResult onay = MessageBox.Show($"{musteri} isimli müşterinin raporunu silmek istediğinize emin misiniz?",
                    "Rapor Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (onay == DialogResult.Yes)
                {
                    try
                    {
                        // 4. Veritabanı bağlantısı (raporekle veritabanına bağlanıyoruz)
                        string conStr = @"Server=DESKTOP-2O9O96Q\SQLEXPRESS;Database=raporekle;Trusted_Connection=True;";
                        using (SqlConnection conn = new SqlConnection(conStr))
                        {
                            // Tablo adın: GitarRaporlarii
                            string query = "DELETE FROM GitarRaporlarii WHERE ID=@id";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", id);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        // 5. İşlem bitince listeyi yeniliyoruz
                        MessageBox.Show("Rapor başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RaporlariYukle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme sırasında hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden silmek istediğiniz bir raporu seçin.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var view = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view.FocusedRowHandle >= 0)
            {
                int id = Convert.ToInt32(view.GetFocusedRowCellValue("ID"));
                yenirapor frm = new yenirapor();
                frm.GelenID = id; // İşte bu satır veriyi taşıyor
                frm.ShowDialog();
                RaporlariYukle();
            }
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecici = new OpenFileDialog();
            dosyaSecici.Filter = "Resim Dosyaları|*.jpg;*.png;*.jpeg";
            dosyaSecici.Title = "AI Analizi İçin Fotoğraf Seçin";

            if (dosyaSecici.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 2. Dosya Bilgilerini Al
                    string kaynakYol = dosyaSecici.FileName;
                    string dosyaAdi = System.IO.Path.GetFileName(kaynakYol);

                    // 3. Senin Sabit Fotoğraf Klasörün
                    // Başına @ koymayı unutma, Mert Can ismindeki boşluk hata vermesin
                    string hedefKlasor = @"C:\Users\Mert Can Yücedağ\Desktop\240542023_NTP_PROJE\Fotoğraflar\";
                    string hedefTamYol = System.IO.Path.Combine(hedefKlasor, dosyaAdi);

                    // 4. Dosya Kopyalama İşlemi (Hata almamak için kontrolle yapıyoruz)
                    // Eğer dosya zaten oradaysa kopyalamayı atla, değilse kopyala
                    if (kaynakYol.ToLower() != hedefTamYol.ToLower())
                    {
                        System.IO.File.Copy(kaynakYol, hedefTamYol, true);
                    }

                    // 5. ChatBot (MemoEdit) Ekranına Yazdırma
                   
                    ChatBot.Text += "Siz: [FOTOĞRAF GÖNDERİLDİ: " + dosyaAdi + "]" + Environment.NewLine;

                    // AI Yanıt Simülasyonu
                    ChatBot.Text += "Tamir AI: '" + dosyaAdi + "' görseli başarıyla alındı." + Environment.NewLine;
                    
                    

                    // 6. Otomatik Aşağı Kaydırma
                    ChatBot.SelectionStart = ChatBot.Text.Length;
                    ChatBot.ScrollToCaret();
                }
                catch (Exception ex)
                {
                    // Hata olursa (Dosya kullanımda vs.) kullanıcıya bildir
                    MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

