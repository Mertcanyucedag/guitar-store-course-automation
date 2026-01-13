using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;


namespace GitarMagazaOtomasyonu
{
    public partial class AnaSayfa : DevExpress.XtraEditors.XtraForm
    {
       

        public static string KullaniciRolu { get; set; } // "Admin" veya "User" değerlerini alacak
        int filtreKoyulugu1 = 150;
        int filtreKoyulugu2 = 150; // Buton 2 için özel değişken
        int filtreKoyulugu = 150;
        private void simpleButton3_MouseEnter(object sender, EventArgs e)
        {

            filtreKoyulugu = 80; // Fare üstündeyken daha aydınlık (siyahlık azaldı)
            simpleButton3.Invalidate(); // Butonu yeniden çizdir (Paint'i tetikler)
        }

        private void simpleButton3_MouseLeave(object sender, EventArgs e)
        {
            filtreKoyulugu = 150; // Fare gidince eski karanlık haline dön
            simpleButton3.Invalidate(); // Butonu yeniden çizdir
        }
        public AnaSayfa()
        {
            InitializeComponent();
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
            this.ShowIcon = false;
            simpleButton1.AllowFocus = false;
            simpleButton2.AllowFocus = false;
            simpleButton3.AllowFocus = false;
           
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            SkinManager.EnableFormSkins(); // Form skinlerini aktif et
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier);
            labelControl4.Text = KullaniciRolu;
            simpleButton3.ImageOptions.Image = Image.FromFile("C:\\Users\\Mert Can Yücedağ\\Desktop\\240542023_NTP_PROJE\\Fotoğraflar\\buton3.jpg");
            simpleButton2.ImageOptions.Image = Image.FromFile("C:\\Users\\Mert Can Yücedağ\\Desktop\\240542023_NTP_PROJE\\Fotoğraflar\\buton2.jpg");
            simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            simpleButton1.ImageOptions.Image = Image.FromFile("C:\\Users\\Mert Can Yücedağ\\Desktop\\240542023_NTP_PROJE\\Fotoğraflar\\buton1.png");



         
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult secim = DevExpress.XtraEditors.XtraMessageBox.Show(
        "Oturumu kapatmak istediğinize emin misiniz?",
        "Çıkış Onayı",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (secim == DialogResult.Yes)
            {

                Form1 frmGiris = new Form1();
                frmGiris.Show();


                this.Dispose();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (KullaniciRolu.ToLower() == "admin")
            {
                TamirAI tamirai = new TamirAI();
                tamirai.Show();
                this.Hide();
            }
            else
            {
                kullaniciai tamirai = new kullaniciai();
                tamirai.Show();
                this.Hide();
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (KullaniciRolu.ToLower() == "admin")
            {
                KursSayfasi kurss = new KursSayfasi();
                kurss.Show();
                this.Hide();
            }
            else
            {
                kullanicikurs kurss = new kullanicikurs();
                kurss.Show();
                this.Hide();
            }
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (KullaniciRolu.ToLower() == "admin")
            {
                StokSayfasi stok = new StokSayfasi();
            stok.Show();
            this.Hide();
            }
            else
            {
                kullanicistok stok = new kullanicistok();
                stok.Show();
                this.Hide();
            }
        }

        private void simpleButton3_Paint(object sender, PaintEventArgs e)
        {
            // 1. Dinamik siyah filtre (Fare üstündeyken filtreKoyulugu azalacak)
            using (Brush shadowBrush = new SolidBrush(Color.FromArgb(filtreKoyulugu, Color.Black)))
            {
                e.Graphics.FillRectangle(shadowBrush, e.ClipRectangle);
            }

            // 2. Yazıyı her zaman en üstte tut
            string metin = simpleButton3.Text;
            Font font = simpleButton3.Appearance.Font;

            // Yazıyı ortala
            SizeF textSize = e.Graphics.MeasureString(metin, font);
            float x = (simpleButton3.Width - textSize.Width) / 2;
            float y = (simpleButton3.Height - textSize.Height) / 2;

            e.Graphics.DrawString(metin, font, Brushes.White, x, y);
        }

        private void simpleButton3_MouseEnter_1(object sender, EventArgs e)
        {
            filtreKoyulugu = 80;

            // Butona "kendini hemen yeniden boya" emri veriyoruz ki Paint olayı tetiklensin
            simpleButton3.Invalidate();
        }

        private void simpleButton3_MouseLeave_1(object sender, EventArgs e)
        {
            // 1. Siyahlık miktarını tekrar artır (Eski koyu haline döndür)
            filtreKoyulugu = 150;

            // 2. Butona "Kendini hemen yeniden boya" de (Paint olayını tetikler)
            simpleButton3.Invalidate();

            // 3. (Opsiyonel) Eğer hala değişmiyorsa çizimi zorla
            simpleButton3.Update();
        }

        private void simpleButton2_Paint(object sender, PaintEventArgs e)
        {
            using (Brush shadowBrush = new SolidBrush(Color.FromArgb(filtreKoyulugu2, Color.Black)))
            {
                e.Graphics.FillRectangle(shadowBrush, e.ClipRectangle);
            }

            string metin = simpleButton2.Text;
            Font font = simpleButton2.Appearance.Font;
            SizeF textSize = e.Graphics.MeasureString(metin, font);
            float x = (simpleButton2.Width - textSize.Width) / 2;
            float y = (simpleButton2.Height - textSize.Height) / 2;
            e.Graphics.DrawString(metin, font, Brushes.White, x, y);

        }

        private void simpleButton2_MouseEnter(object sender, EventArgs e)
        {
            filtreKoyulugu2 = 80;
            simpleButton2.Invalidate();
        }

        private void simpleButton2_MouseLeave(object sender, EventArgs e)
        {
            filtreKoyulugu2 = 150;
            simpleButton2.Invalidate();
        }

        private void simpleButton1_Paint(object sender, PaintEventArgs e)
        {
            using (Brush shadowBrush = new SolidBrush(Color.FromArgb(filtreKoyulugu1, Color.Black)))
            {
                e.Graphics.FillRectangle(shadowBrush, e.ClipRectangle);
            }

            
           string metin = simpleButton1.Text;
           Font font = simpleButton1.Appearance.Font;
            SizeF textSize = e.Graphics.MeasureString(metin, font);
            float x = (simpleButton1.Width - textSize.Width) / 2;
            float y = (simpleButton1.Height - textSize.Height) / 2;
           e.Graphics.DrawString(metin, font, Brushes.White, x, y);
       }

        private void simpleButton1_MouseEnter(object sender, EventArgs e)
        {
            filtreKoyulugu1 = 80; // Üstüne gelince parlat (siyahlığı azalt)
            simpleButton1.Invalidate(); // Yeniden çizdir
        }

        private void simpleButton1_MouseLeave(object sender, EventArgs e)
        {
           filtreKoyulugu1 = 150; // Ayrılınca karart
            simpleButton1.Invalidate(); // Yeniden çizdir
            simpleButton1.Update(); // Değişikliği anında ekrana yansıt
        }
    }
}
