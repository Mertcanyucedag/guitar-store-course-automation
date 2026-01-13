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
    public partial class KursSayfasi : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2O9O96Q\SQLEXPRESS;Initial Catalog=kursbilgi;Integrated Security=True");
        public KursSayfasi()
        {


            InitializeComponent();
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);

            

        }

        private void KursSayfasi_Load(object sender, EventArgs e)
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

            simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            // 2. Buton stilini 'Simple' yaparak çerçeveyi görünür kılıyoruz
            simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            // 3. Çerçeve rengini senin turuncuna (#FF8C00) boyuyoruz
            simpleButton2.Appearance.Options.UseBorderColor = true;
            simpleButton2.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            // 4. (Opsiyonel) Mouse ile üzerine gelince çerçevenin beyaz parlamasını istersen:
            simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton2.AppearanceHovered.BorderColor = Color.White;

            // 1. Temayı devre dışı bırakıp düz (flat) stile geçiyoruz
            simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            simpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            // 2. Buton stilini 'Simple' yaparak çerçeveyi görünür kılıyoruz
            simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            // 3. Çerçeve rengini senin turuncuna (#FF8C00) boyuyoruz
            simpleButton2.Appearance.Options.UseBorderColor = true;
            simpleButton2.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            // 4. (Opsiyonel) Mouse ile üzerine gelince çerçevenin beyaz parlamasını istersen:
            simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            simpleButton2.AppearanceHovered.BorderColor = Color.White;









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


        private void KursSayfasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                
                SqlCommand komut = new SqlCommand("INSERT INTO TBL_KURSIYERLER (ADSOYAD, GITARMODEL, ODEME) VALUES (@p1, @p2, @p3)", baglanti);

                
                komut.Parameters.AddWithValue("@p1", txtAd.Text);    
                komut.Parameters.AddWithValue("@p2", txtModel.Text); 
                komut.Parameters.AddWithValue("@p3", cmbOdeme.Text); 
                         

               
                komut.ExecuteNonQuery();

                
                baglanti.Close();

                DevExpress.XtraEditors.XtraMessageBox.Show("Kursiyer başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                Listele();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_KURSIYERLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AnaSayfa frmGiris = new AnaSayfa();
            frmGiris.Show();

           
            this.Dispose(); 
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
