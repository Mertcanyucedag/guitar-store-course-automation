using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitarMagazaOtomasyonu
{
    public partial class kullaniciai : DevExpress.XtraEditors.XtraForm
    {
        private List<object> basitChatHistory = new List<object>();
        private readonly string apiKey = "YOUR_API_KEY";
        public kullaniciai()
        {
            InitializeComponent();

            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
        }

        private void kullaniciai_Load(object sender, EventArgs e)
        {
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
            rprSil.LookAndFeel.UseDefaultLookAndFeel = false;
            rprSil.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            rprSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            rprSil.Appearance.Options.UseBorderColor = true;
            rprSil.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");
            rprSil.AppearanceHovered.Options.UseBorderColor = true;
            rprSil.AppearanceHovered.BorderColor = Color.White;


            //


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
            btnDosyaSec.LookAndFeel.UseDefaultLookAndFeel = false;
            btnDosyaSec.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            btnDosyaSec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btnDosyaSec.Appearance.Options.UseBorderColor = true;
            btnDosyaSec.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");
            btnDosyaSec.AppearanceHovered.Options.UseBorderColor = true;
            btnDosyaSec.AppearanceHovered.BorderColor = Color.White;


            //


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
            btnGonder.LookAndFeel.UseDefaultLookAndFeel = false;
            btnGonder.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            btnGonder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            btnGonder.Appearance.Options.UseBorderColor = true;
            btnGonder.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");
            btnGonder.AppearanceHovered.Options.UseBorderColor = true;
            btnGonder.AppearanceHovered.BorderColor = Color.White;
        }

        private void kullaniciai_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rprSil_Click(object sender, EventArgs e)
        {
            AnaSayfa frmGiris = new AnaSayfa();
            frmGiris.Show();
            this.Dispose();
        }

        private async void btnGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(memoEdit1.Text)) return;

            string kullaniciMesaji = memoEdit1.Text;
            ChatBot.Text += $"SİZ: {kullaniciMesaji}{Environment.NewLine}";

            // AI'ya uzmanlık rolü veriyoruz
            string uzmanlikMesaji = "Teknik ve kısa bir anlatım ile tıpkı bir Profesyonel Gitar Onarım uzmanı (Luthier) gibi cevapla ve * karakteri kullanmadan kullanıcıya doğrudan yansıtılacaktır, akor yardımı gitar vb çoğu konuda yardımcı ol unutma KISA CEVAP vermelisin. çok uzatmadan anlatman gereken konu şu : \" " + kullaniciMesaji;

            // Hafızaya ekle
            basitChatHistory.Add(new { role = "user", parts = new[] { new { text = uzmanlikMesaji } } });
            memoEdit1.Text = "";

            try
            {
                ChatBot.Text += "AI: Yanıt bekleniyor..." + Environment.NewLine;

                string requestUri = $"https://generativelanguage.googleapis.com/v1/models/gemini-2.5-flash:generateContent?key={apiKey}";

                var requestBody = new { contents = basitChatHistory.ToArray() };
                string jsonPayload = JsonConvert.SerializeObject(requestBody);

                using var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                using var client = new HttpClient();

                var response = await client.PostAsync(requestUri, content);
                string responseString = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(responseString);

                if (result.candidates != null && result.candidates.Count > 0)
                {

                    string aiCevap = result.candidates[0].content.parts[0].text;

                    // Yanıtı ekrana yaz
                    ChatBot.Text += $"AI: {aiCevap}{Environment.NewLine}";
                    ChatBot.Text += "-----------------------------------" + Environment.NewLine;

                    // Yanıtı hafızaya ekle (sohbetin devam edebilmesi için)
                    basitChatHistory.Add(new { role = "model", parts = new[] { new { text = aiCevap } } });
                }
            }
            catch (Exception ex)
            {
                ChatBot.Text += $"SİSTEM HATASI: {ex.Message}{Environment.NewLine}";
            }

            // Otomatik aşağı kaydır
            ChatBot.SelectionStart = ChatBot.Text.Length;
            ChatBot.ScrollToCaret();
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
