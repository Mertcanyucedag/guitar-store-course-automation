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
    public partial class kullanicistok : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2O9O96Q\SQLEXPRESS;Initial Catalog=StokControl;Integrated Security=True");
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
        public kullanicistok()
        {
            InitializeComponent();
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
        }

        private void kullanicistok_Load(object sender, EventArgs e)
        {
            Listele();
            if (gridView1.Columns["ALISFIYAT"] != null)
            {
                gridView1.Columns["ALISFIYAT"].Visible = false;
                gridView1.Columns["ALISFIYAT"].OptionsColumn.ShowInCustomizationForm = false;
            }
            if (gridView1.Columns["YUZDEKDVORAN"] != null)
            {
                gridView1.Columns["YUZDEKDVORAN"].Visible = false;
                gridView1.Columns["YUZDEKDVORAN"].OptionsColumn.ShowInCustomizationForm = false;
            }
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
        }

        private void kullanicistok_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AnaSayfa frmGiris = new AnaSayfa();
            frmGiris.Show();

            // Bu (AnaSayfa) formu kapatıyoruz
            this.Dispose(); // Hafızadan tamamen temizler
        }
    }
}
