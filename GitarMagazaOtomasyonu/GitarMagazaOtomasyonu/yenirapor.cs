using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing;
using System.IO;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GitarMagazaOtomasyonu
{
    public partial class yenirapor : DevExpress.XtraEditors.XtraForm
    {
        public int GelenID = 0;
        public yenirapor()
        {
            InitializeComponent();
            this.ShowIcon = false;
            this.LookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 9);
            cmbCozumDurumu.Properties.Items.Clear();
            cmbCozumDurumu.Properties.Items.Add("Çözüldü");
            cmbCozumDurumu.Properties.Items.Add("Beklemede");
            cmbCozumDurumu.Properties.Items.Add("Çözülemedi");
            cmbCozumDurumu.SelectedIndex = 2;
            txtGitarProblem.Items.Clear();
            txtGitarProblem.Items.Add("Kırık Sap");
            txtGitarProblem.Items.Add("Çatlak Sap");
            txtGitarProblem.Items.Add("Klavye Temizliği");
            txtGitarProblem.Items.Add("Tel Yükseklik Ayarı");
            txtGitarProblem.Items.Add("Tel Kopması");
            txtGitarProblem.Items.Add("Sap Ayarı");
            txtGitarProblem.Items.Add("Elektronik Arıza");
            txtGitarProblem.Items.Add("Genel Bakım");
            txtGitarProblem.Items.Add("Diğer");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
        }
        private void VerileriGetir(int id)
        {
            string conStr = @"Server=DESKTOP-2O9O96Q\SQLEXPRESS;Database=raporekle;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = "SELECT * FROM GitarRaporlarii WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtMusteriAdSoyad.Text = dr["MusteriAdSoyad"].ToString();
                    txtGitarProblem.Text = dr["GitarProblemi"].ToString();
                    cmbCozumDurumu.Text = dr["CozumDurumu"].ToString();
                    memoYapilanIslemler.Text = dr["YapilanIslemler"].ToString();

                    if (dr["GitarFotograf"] != DBNull.Value)
                    {
                        byte[] imgData = (byte[])dr["GitarFotograf"];
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            picGitarFotograf.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }
        private void yenirapor_Load(object sender, EventArgs e)
        {
            btnKaydet.Visible = true;
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl1.Appearance.BackColor = Color.FromArgb(29, 31, 33);
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Text = "Rapor Detayı";
            btnKaydet.Visible = false;
            VerileriGetir(GelenID);
            btnKaydet.Visible = true;

            btnFotografSec.LookAndFeel.UseDefaultLookAndFeel = false;
            btnFotografSec.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            btnFotografSec.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            btnFotografSec.Appearance.Options.UseForeColor = true;
            btnFotografSec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnFotografSec.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnFotografSec.AppearanceHovered.Options.UseBackColor = true;
            btnFotografSec.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            btnFotografSec.AppearanceHovered.Options.UseForeColor = true;
            btnFotografSec.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            btnFotografSec.AppearanceHovered.Options.UseBorderColor = true;
            btnFotografSec.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            btnKaydet.LookAndFeel.UseDefaultLookAndFeel = false;
            btnKaydet.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            btnKaydet.Appearance.ForeColor = ColorTranslator.FromHtml("#FF8C00");
            btnKaydet.Appearance.Options.UseForeColor = true;
            btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnKaydet.Appearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnKaydet.AppearanceHovered.Options.UseBackColor = true;
            btnKaydet.AppearanceHovered.BackColor = Color.FromArgb(60, 60, 60);
            btnKaydet.AppearanceHovered.Options.UseForeColor = true;
            btnKaydet.AppearanceHovered.ForeColor = Color.FromArgb(255, 165, 0);
            btnKaydet.AppearanceHovered.Options.UseBorderColor = true;
            btnKaydet.AppearanceHovered.BorderColor = ColorTranslator.FromHtml("#FF8C00");





            // 1. Temayı devre dışı bırakıp düz (flat) stile geçiyoruz
            btnKaydet.LookAndFeel.UseDefaultLookAndFeel = false;
            btnKaydet.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            // 2. Buton stilini 'Simple' yaparak çerçeveyi görünür kılıyoruz
            btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            // 3. Çerçeve rengini senin turuncuna (#FF8C00) boyuyoruz
            btnKaydet.Appearance.Options.UseBorderColor = true;
            btnKaydet.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            // 4. (Opsiyonel) Mouse ile üzerine gelince çerçevenin beyaz parlamasını istersen:
            btnKaydet.AppearanceHovered.Options.UseBorderColor = true;
            btnKaydet.AppearanceHovered.BorderColor = Color.White;



            btnFotografSec.LookAndFeel.UseDefaultLookAndFeel = false;
            btnFotografSec.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            // 2. Buton stilini 'Simple' yaparak çerçeveyi görünür kılıyoruz
            btnFotografSec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            // 3. Çerçeve rengini senin turuncuna (#FF8C00) boyuyoruz
            btnFotografSec.Appearance.Options.UseBorderColor = true;
            btnFotografSec.Appearance.BorderColor = ColorTranslator.FromHtml("#FF8C00");

            // 4. (Opsiyonel) Mouse ile üzerine gelince çerçevenin beyaz parlamasını istersen:
            btnFotografSec.AppearanceHovered.Options.UseBorderColor = true;
            btnFotografSec.AppearanceHovered.BorderColor = Color.White;
        }

        private void txtGitarProblem_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void btnFotografSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif|Tüm Dosyalar|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                picGitarFotograf.Image = Image.FromFile(dialog.FileName);


                picGitarFotograf.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string conStr = @"Server=DESKTOP-2O9O96Q\SQLEXPRESS;Database=raporekle;Trusted_Connection=True;";
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    string query = "";


                    if (GelenID > 0)
                    {
                        query = @"UPDATE GitarRaporlarii SET 
                          MusteriAdSoyad=@p1, GitarProblemi=@p2, CozumDurumu=@p3, 
                          YapilanIslemler=@p4, GitarFotograf=@p5 
                          WHERE ID=@id";
                    }
                    else
                    {
                        query = @"INSERT INTO GitarRaporlarii 
                          (MusteriAdSoyad, GitarProblemi, CozumDurumu, YapilanIslemler, GitarFotograf, KayitTarihi) 
                          VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@p1", txtMusteriAdSoyad.Text);
                    cmd.Parameters.AddWithValue("@p2", txtGitarProblem.Text);
                    cmd.Parameters.AddWithValue("@p3", cmbCozumDurumu.Text);
                    cmd.Parameters.AddWithValue("@p4", memoYapilanIslemler.Text);


                    if (GelenID > 0) cmd.Parameters.AddWithValue("@id", GelenID);

                    else cmd.Parameters.AddWithValue("@p6", DateTime.Now);


                    if (picGitarFotograf.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picGitarFotograf.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            cmd.Parameters.AddWithValue("@p5", ms.ToArray());
                        }
                    }
                    else { cmd.Parameters.AddWithValue("@p5", DBNull.Value); }

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                MessageBox.Show(GelenID > 0 ? "Rapor başarıyla güncellendi." : "Rapor kaydedildi.", "Başarılı");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCozumDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
