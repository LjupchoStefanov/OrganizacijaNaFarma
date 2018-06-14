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

namespace Organizacija_na_farma
{
    public partial class OSForm : Form
    {
        public OSForm()
        {
            InitializeComponent();
        }

        public String makeDate(String date)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(date.Substring(6, 4));
            sb.Append(date.Substring(3, 2));
            sb.Append(date.Substring(0,2));
            
            
            return sb.ToString();
        }



        private void Save_Click(object sender, EventArgs e)
        {
            // testiranje push na ljupcho branc
            String naziv = TBNaziv.Text;
            String Fmajka = textBoxFMajka.Text;
            String pol = TBPol.Text;
            String vid = TBVid.Text;
            String majka = TBMajka.Text;
            String tatko = TBTatko.Text;
            String Mmajka = TBBabaMajka.Text;
            String TMajka = TBDedoMajka.Text;
            String MTatko = TBBabaTatko.Text;
            String TTatko = TBDedoTatko.Text;
            String datum = makeDate(MTBDatum.Text);
            label1.Text = datum;
            DataAcess DA = new DataAcess();
            //"',cast('" + datum + "' as datetime)
            SqlCommand cmd1 = new SqlCommand("Insert Into tblOS(IDF,FMajka,Naziv2,Pol,VID,FF,MM,FFF,FMM,MMF,MMM,RagjanjeDatum,Aktivno) " +
                "Values(55,N'"+ Fmajka +"',N'" + naziv +"',N'" + pol + "',N'" + vid + "',N'" + majka + "',N'" + tatko +"'" +
                ",N'" + Mmajka + "',N'" + TMajka + "',N'" + MTatko + "',N'" + TTatko + "',cast('" + datum + "' as datetime),'1')", DA.getConnection());
            DA.cmdInesrt(cmd1);


        }
    }
}
