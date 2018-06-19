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
    public partial class DvizenjeForm : Form
    {
        public DataAcess DA { get; set; }
        public DvizenjeForm()
        {
            InitializeComponent();
            DA = new DataAcess();
            SqlConnection conn = DA.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Top 1 * from tblDvizenje where ID = '1'");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox3.Text = reader["Priem"].ToString();
            }
            conn.Close();

            conn.Open();
            cmd = new SqlCommand("Select Top 1 * from tblDvizenje where ID = '2'");
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox4.Text = reader["Priem"].ToString();
            }
            conn.Close();

            conn.Open();
            cmd = new SqlCommand("Select Top 1 * from tblDvizenje where ID = '3'");
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox5.Text = reader["Priem"].ToString();
            }
            conn.Close();
            
        }
        private void cbSkladiliste1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm1.Enabled = true;
            cbSkladiliste2.Enabled = false;
        }

        private void cm1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mbDatum1.Enabled = true;
        }

        private void mbDatum1_TextChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
        }

        private void cbSkladiliste2_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = true;
            cbSkladiliste1.Enabled = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            mbDatum2.Enabled = true;
        }

        private void mbDatum2_TextChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
        }

        private void Refresh()
        {
            cbSkladiliste1.ClearSelected();
            cm1.ResetText();
            numericUpDown1.Value = 0;
            mbDatum1.ResetText();
            cbSkladiliste2.ClearSelected();
            numericUpDown2.Value = 0;
            mbDatum2.ResetText();
            cbSkladiliste1.Enabled = true;
            cbSkladiliste2.Enabled = true;
            cm1.Enabled = false;
            numericUpDown1.Enabled = false;
            mbDatum1.Enabled = false;
            numericUpDown2.Enabled = false;
            mbDatum2.Enabled = false;
            buttonSave.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if ((cm1.Text.Trim().Length != 0 && numericUpDown1.Value != 0 && mbDatum1.Text.Trim().Length == 10) || (numericUpDown2.Value != 0 && mbDatum2.Text.Trim().Length == 10))
            {
                if (cbSkladiliste1.SelectedIndex != -1)
                {
                    if (cm1.SelectedIndex != -1)
                    {
                        if ((int)numericUpDown1.Value != 0)
                        {
                            if (mbDatum1.Text.Length == 10)
                            {
                                DA = new DataAcess();
                                if (cm1.SelectedItem.ToString().Equals("Купено") || cm1.SelectedItem.ToString().Equals("Родено"))
                                {
                                    SqlCommand cmd1 = new SqlCommand("Insert Into tblDvizenje(ID,Skladiste,VidDvizenje,Priem,Izdavanje,Datum)" +
                                    " Values(0,N'" + cbSkladiliste1.SelectedItem.ToString() + "',N'" + cm1.SelectedItem.ToString() + "',N'" + (int)numericUpDown1.Value + "', '0', cast('" + MakeDate.makeDate(mbDatum1.Text) + "' as datetime))", DA.getConnection());
                                    DA.cmdCommand(cmd1);
                                    if (cbSkladiliste1.SelectedItem.ToString().Equals("Прасилиште"))
                                    {
                                        int tmp = int.Parse(textBox3.Text);
                                        textBox3.Text = (tmp + (int)numericUpDown1.Value).ToString();
                                        cmd1 = new SqlCommand("Update tblDvizenje set Priem = '" + int.Parse(textBox3.Text) + "' where id = '1'", DA.getConnection());
                                        DA.cmdCommand(cmd1);
                                        Refresh();
                                    }
                                    else if (cbSkladiliste1.SelectedItem.ToString().Equals("Б-Фаза"))
                                    {
                                        int tmp = int.Parse(textBox4.Text);
                                        textBox4.Text = (tmp + (int)numericUpDown1.Value).ToString();
                                        cmd1 = new SqlCommand("Update tblDvizenje set Priem = '" + int.Parse(textBox4.Text) + "' where id = '2'", DA.getConnection());
                                        DA.cmdCommand(cmd1);
                                        Refresh();
                                    }
                                    else
                                    {
                                        int tmp = int.Parse(textBox5.Text);
                                        textBox5.Text = (tmp + (int)numericUpDown1.Value).ToString();
                                        cmd1 = new SqlCommand("Update tblDvizenje set Priem = '" + int.Parse(textBox5.Text) + "' where id = '3'", DA.getConnection());
                                        DA.cmdCommand(cmd1);
                                        Refresh();
                                    }
                                }
                                else
                                {
                                    SqlCommand cmd1 = new SqlCommand("Insert Into tblDvizenje(ID,Skladiste,VidDvizenje,Priem,Izdavanje,Datum) " +
                                    "Values(0,N'" + cbSkladiliste1.SelectedItem.ToString() + "',N'" + cm1.SelectedItem.ToString() + "', '0', N'" + (int)numericUpDown1.Value +
                                    "',cast('" + MakeDate.makeDate(mbDatum1.Text) + "' as datetime))", DA.getConnection());
                                    DA.cmdCommand(cmd1);
                                    if (cbSkladiliste1.SelectedItem.ToString().Equals("Прасилиште"))
                                    {
                                        int tmp = int.Parse(textBox3.Text);
                                        textBox3.Text = (tmp - (int)numericUpDown1.Value).ToString();
                                        cmd1 = new SqlCommand("Update tblDvizenje set Priem = '" + int.Parse(textBox3.Text) + "' where id = '1'", DA.getConnection());
                                        DA.cmdCommand(cmd1);
                                        Refresh();
                                    }
                                    else if (cbSkladiliste1.SelectedItem.ToString().Equals("Б-Фаза"))
                                    {
                                        int tmp = int.Parse(textBox4.Text);
                                        textBox4.Text = (tmp - (int)numericUpDown1.Value).ToString();
                                        cmd1 = new SqlCommand("Update tblDvizenje set Priem = '" + int.Parse(textBox4.Text) + "' where id = '2'", DA.getConnection());
                                        DA.cmdCommand(cmd1);
                                        Refresh();
                                    }
                                    else
                                    {
                                        int tmp = int.Parse(textBox5.Text);
                                        textBox5.Text = (tmp - (int)numericUpDown1.Value).ToString();
                                        cmd1 = new SqlCommand("Update tblDvizenje set Priem = '" + int.Parse(textBox5.Text) + "' where id = '3'", DA.getConnection());
                                        DA.cmdCommand(cmd1);
                                        Refresh();
                                    }
                                }


                            }
                        }
                    }

                }
                else if (cbSkladiliste2.SelectedIndex != -1)
                {
                    if ((int)numericUpDown2.Value != 0)
                    {
                        if (mbDatum2.Text.Length == 10)
                        {
                            DataAcess DA = new DataAcess();
                            if (cbSkladiliste2.SelectedItem.ToString().Equals("Прасилиште - Б-Фаза"))
                            {
                                SqlCommand cmd1 = new SqlCommand("Insert Into tblDvizenje(ID,Skladiste,VidDvizenje,Priem, Izdavanje, Datum) " +
                                "Values(0,N'Прасилиште', N'Пренос', '0', N'" + (int)numericUpDown2.Value +
                                "', cast('" + MakeDate.makeDate(mbDatum2.Text) + "' as datetime))", DA.getConnection());
                                DA.cmdCommand(cmd1);

                                int tmp = int.Parse(textBox3.Text);
                                textBox3.Text = (tmp - (int)numericUpDown2.Value).ToString();
                                cmd1 = new SqlCommand("Update tblDvizenje set Priem = '" + int.Parse(textBox3.Text) + "' where id = '1'", DA.getConnection());
                                DA.cmdCommand(cmd1);

                                cmd1 = new SqlCommand("Insert Into tblDvizenje(ID,Skladiste,VidDvizenje,Priem, Izdavanje,Datum) " +
                                "Values(0,N'Б-Фаза', N'Пренос', N'" + (int)numericUpDown2.Value +
                                "', '0', cast('" + MakeDate.makeDate(mbDatum2.Text) + "' as datetime))", DA.getConnection());
                                DA.cmdCommand(cmd1);

                                tmp = int.Parse(textBox4.Text);
                                textBox4.Text = (tmp + (int)numericUpDown2.Value).ToString();
                                cmd1 = new SqlCommand("Update tblDvizenje set Priem = '" + int.Parse(textBox4.Text) + "' where id = '2'", DA.getConnection());
                                DA.cmdCommand(cmd1);

                                Refresh();
                            }
                            else
                            {
                                SqlCommand cmd1 = new SqlCommand("Insert Into tblDvizenje(ID,Skladiste,VidDvizenje,Priem,Izdavanje,Datum) " +
                                "Values(0,N'Б-Фаза', N'Пренос', '0', N'" + (int)numericUpDown2.Value +
                                "', cast('" + MakeDate.makeDate(mbDatum2.Text) + "' as datetime))", DA.getConnection());
                                DA.cmdCommand(cmd1);

                                int tmp = int.Parse(textBox4.Text);
                                textBox4.Text = (tmp - (int)numericUpDown2.Value).ToString();
                                cmd1 = new SqlCommand("Update tblDvizenje set Priem = '" + int.Parse(textBox4.Text) + "' where id = '2'", DA.getConnection());
                                DA.cmdCommand(cmd1);

                                cmd1 = new SqlCommand("Insert Into tblDvizenje(ID,Skladiste,VidDvizenje,Priem,Izdavanje,Datum) " +
                                "Values(0,N'Товилиште', N'Пренос', N'" + (int)numericUpDown2.Value +
                                "', '0', cast('" + MakeDate.makeDate(mbDatum2.Text) + "' as datetime))", DA.getConnection());
                                DA.cmdCommand(cmd1);

                                tmp = int.Parse(textBox5.Text);
                                textBox5.Text = (tmp + (int)numericUpDown2.Value).ToString();
                                cmd1 = new SqlCommand("Update tblDvizenje set Priem = '" + int.Parse(textBox5.Text) + "' where id = '3'", DA.getConnection());
                                DA.cmdCommand(cmd1);

                                Refresh();
                            }
                        }
                    }
                }
            }
            else MessageBox.Show("Внеси ги потребните податоци!");
        }

        private void cm1_Validating(object sender, CancelEventArgs e)
        {
            if (cm1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(cm1, "Внеси вид на движење");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cm1, null);
                e.Cancel = false;
            }
        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                errorProvider1.SetError(numericUpDown1, "Внеси прием");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(numericUpDown1, null);
                e.Cancel = false;
            }
        }

        private void mbDatum1_Validating(object sender, CancelEventArgs e)
        {
            if (mbDatum1.Text.Trim().Length != 10)
            {
                errorProvider1.SetError(mbDatum1, "Внеси датум");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mbDatum1, null);
                e.Cancel = false;
            }
        }

        private void numericUpDown2_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown2.Value == 0)
            {
                errorProvider1.SetError(numericUpDown2, "Внеси прием");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(numericUpDown2, null);
                e.Cancel = false;
            }
        }

        private void mbDatum2_Validating(object sender, CancelEventArgs e)
        {
            if (mbDatum2.Text.Trim().Length != 10)
            {
                errorProvider1.SetError(mbDatum2, "Внеси датум");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mbDatum2, null);
                e.Cancel = false;
            }
        }
    }

}
