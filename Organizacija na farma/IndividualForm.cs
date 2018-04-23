using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizacija_na_farma
{
    public partial class IndividualForm : Form
    {
        public IndividualForm()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewIndividualForm newForm = new NewIndividualForm();
            newForm.Show();
        }
    }
}
