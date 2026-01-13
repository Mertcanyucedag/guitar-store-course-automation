using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace GitarMagazaOtomasyonu
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        public Form1()
        {
            InitializeComponent();
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
            simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

            // Alternatif olarak çerçeve rengini arka planla aynı yapabilirsin
            simpleButton1.Appearance.BorderColor = Color.FromArgb(45, 45, 48);

            // 2. Yazı rengini senin istediğin turuncu koduna ayarla
            simpleButton1.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");

            // 3. Fontu kalın yaparak turuncunun daha belirgin olmasını sağla (Hocanın gözüne hitap eder)


            // 4. ForeColor kullanımını zorunlu kıl
            simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            simpleButton1.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60); // Hafifçe açılan gri (parlama hissi)

            // 2. Üzerine gelince yazı rengini daha parlak bir turuncu yap
            simpleButton1.AppearanceHovered.Options.UseForeColor = true;
            simpleButton1.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0); // Daha canlı turuncu

            // 3. İsteğe bağlı: Üzerine gelince turuncu ince bir çerçeve çıksın (parlama efekti)
            simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton1.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            string baglantiDizisi = @"Server=localhost\SQLEXPRESS; Database=GitarMagazaDB; Integrated Security=True; TrustServerCertificate=True;";
            using (SqlConnection baglanti = new SqlConnection(baglantiDizisi))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT KullaniciAdi FROM Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", txtKullanici.Text);
                    komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read()) // Kullanıcı bulundu
                    {
                        string kullaniciAdi = oku["KullaniciAdi"].ToString().ToLower();

                        if (kullaniciAdi == "admin")
                        {
                            AnaSayfa.KullaniciRolu = kullaniciAdi;
                            AnaSayfa frmAdmin = new AnaSayfa();
                            frmAdmin.Show();
                        }
                        else
                        {
                            AnaSayfa.KullaniciRolu = kullaniciAdi;
                            // Burası senin 'kullanici1' için açılacak sayfa
                            AnaSayfa frmKullanici = new AnaSayfa();
                            frmKullanici.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı Hatası: " + ex.Message);
                }
                
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtKullanici_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControw_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.Properties.PasswordChar = '*';
            simpleButton1.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
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

            // 3. Yazı renginin kullanılmasını zorunlu kıl (Kritik ayar)
            simpleButton1.Appearance.Options.UseForeColor = true;
        }

        private void panelControl1_Paint_1(object sender, PaintEventArgs e)
        {
            panelControl1.Appearance.BackColor = Color.FromArgb(46, 46, 46);
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        }
    }
}