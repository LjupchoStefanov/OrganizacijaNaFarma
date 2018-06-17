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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
namespace Organizacija_na_farma
{
    public partial class Main : Form
    {
        public List<int> s;
        public Main()
        {
            InitializeComponent();
        }

        private void buttonIndividual_Click(object sender, EventArgs e)
        {
            OSForm individualForm = new OSForm();
            individualForm.Show();
        }

        private void buttonReproduction_Click(object sender, EventArgs e)
        {
            //ReproductionForm reprodukcija = new ReproductionForm();
            //reprodukcija.Show();
        }

        private void buttonMovment_Click(object sender, EventArgs e)
        {
            //DvizenjeForm dvizenje = new DvizenjeForm();
            //dvizenje.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataAcess DA = new DataAcess();
            SqlConnection conn = DA.getConnection();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO tblDvizenje(ID, Skladiste, VidDvizenje, Priem) VALUES(15055, N'Прасилиштеt', N'Попис', 20)", conn);
            SqlCommand cmd2 = new SqlCommand("UPDATE tblDvizenje SET Datum = cast('20181220' as datetime) Where ID = 15055", conn);
            SqlCommand cmd = new SqlCommand("SELECT Skladiste FROM [Farma].[dbo].[tblDvizenje] WHERE ID = 15055", conn);
            DA.cmdInesrt(cmd1);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IzvestajZadaci zadaci = new IzvestajZadaci();
            zadaci.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Document pdfDoc = new Document();
            SqlDataReader reader = null;
            try
            {
                string FileName = null;
                if (FileName == null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Osnoven izvestaj (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Osnoven izvestaj";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileName = saveFileDialog.FileName;
                    }
                    else
                    {
                        return;                    }
                }
                PdfWriter pdf = PdfWriter.GetInstance(pdfDoc, new FileStream(FileName, FileMode.Create));
                pdfDoc.Open();
                string myFont = @"C:\Windows\Fonts\arial.ttf";
                iTextSharp.text.pdf.BaseFont bfR;
                bfR = iTextSharp.text.pdf.BaseFont.CreateFont(myFont,
                  iTextSharp.text.pdf.BaseFont.IDENTITY_H,
                  iTextSharp.text.pdf.BaseFont.EMBEDDED);

                iTextSharp.text.BaseColor clrBlack =
                    new iTextSharp.text.BaseColor(0, 0, 0);
                iTextSharp.text.Font fntHead =
                    new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, clrBlack);
                //pdfDoc.Add(new Paragraph("ТЕСТ", fntHead));
                PdfPTable table = new PdfPTable(5);
                //PdfPCell cell = new PdfPCell(new Phrase("ОСНОВЕН ИЗВЕШТАЈ"));
                PdfPCell cell = new PdfPCell(new Phrase("OSNOVEN IZVESTAJ"));
                cell.Colspan = 5;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);
                table.AddCell("Meseci");
                table.AddCell("Rodeni");
                table.AddCell("Mrtvo Rodeni");
                table.AddCell("Nevitalni");
                table.AddCell("Odbieni prasinja");
                long vkupnoRodeni = 0;
                long vkupnoMrtvoRodeni = 0;
                long vkupnoNevitalni = 0;
                long vkupnoOdbieniPrasinja = 0;

                DataAcess da = new DataAcess();
                SqlConnection conn = da.getConnection();
                conn.Open();
                for (int i = 1; i < 13; i++) {
                    int k = i + 1;
                    String str = String.Format("Select * FROM tblReprodukcija Where OdbivanjeDatum > DATEADD(MONTH, {0}, GetDate()) and OdbivanjeDatum < DATEADD(MONTH, {1}, GetDate())", -k, -i);
                    SqlCommand cmd = new SqlCommand(str);
                    //SqlCommand cmd = new SqlCommand("Select * FROM tblReprodukcija Where OdbivanjeDatum > DATEADD(MONTH, -'" + k + "' , GetDate()) and OdbivanjeDatum < DATEADD(MONTH, -'" + i +"', GetDate())");
                    cmd.Connection = conn;
                    reader = cmd.ExecuteReader();
                    List<Reproduction> lista = new List<Reproduction>();
                    while (reader.Read())
                    {
                        string Zensko = reader["FMajka"].ToString();
                        string Masko = reader["MTatko"].ToString();
                        string Osemena = reader["OsemenuvanjeDatum"].ToString();
                        string KontrolaDatum = reader["KontrolaDatum"].ToString();
                        bool Kontrola = Boolean.Parse(reader["Kontrola"].ToString());
                        string Oprasena = reader["OprasuvanjeDatum"].ToString();
                        float Rodeni = 0;
                        if (reader["ZivoRodeniPrasinja"].ToString() != "") Rodeni = float.Parse(reader["ZivoRodeniPrasinja"].ToString());
                        float MrtvoRodeni = 0;
                        if (reader["MrtvoRodeniPrasinja"].ToString() != "") MrtvoRodeni = float.Parse(reader["MrtvoRodeniPrasinja"].ToString());
                        float Nevitalni = 0;
                        if (reader["NevitalniPrasinja"].ToString() != "") Nevitalni = float.Parse(reader["NevitalniPrasinja"].ToString());
                        string Odbivanje = reader["OdbivanjeDatum"].ToString();
                        float OdbieniPrasinja = 0;
                        if (reader["OdbieniPrasinja"].ToString() != "") OdbieniPrasinja = float.Parse(reader["OdbieniPrasinja"].ToString());
                        Reproduction pom = new Reproduction(Zensko, Masko, Osemena, KontrolaDatum, Kontrola, Oprasena, Rodeni, MrtvoRodeni, Nevitalni, Odbivanje, OdbieniPrasinja);
                        lista.Add(pom);
                    }
                    int rodeni = 0;
                    int Mrtvi = 0;
                    int nevitalni = 0;
                    int odbieni = 0;
                    for(int m = 0; m < lista.Count; m++)
                    {
                        rodeni += (int)lista[i].Rodeni;
                        Mrtvi += (int)lista[i].MrtvoRodeni;
                        nevitalni += (int)lista[i].Nevitalni;
                        odbieni += (int)lista[i].OdbieniPrasinja;
                    }
                    table.AddCell(i.ToString());
                    vkupnoRodeni += rodeni;
                    table.AddCell(rodeni.ToString());
                    vkupnoMrtvoRodeni += Mrtvi;
                    table.AddCell(Mrtvi.ToString());
                    vkupnoNevitalni += nevitalni;
                    table.AddCell(nevitalni.ToString());
                    vkupnoOdbieniPrasinja += odbieni;
                    table.AddCell(odbieni.ToString());
                    reader.Close();
                }
                table.AddCell("Vkupno");
                table.AddCell(vkupnoRodeni.ToString());
                table.AddCell(vkupnoMrtvoRodeni.ToString());
                table.AddCell(vkupnoNevitalni.ToString());
                table.AddCell(vkupnoOdbieniPrasinja.ToString());
                pdfDoc.Add(table);
                MessageBox.Show("Креаиран е PDF");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
               
                pdfDoc.Close();
            }
        }
              
    }
}
