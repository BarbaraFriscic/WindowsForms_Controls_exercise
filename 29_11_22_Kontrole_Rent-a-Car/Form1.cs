using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_11_22_Kontrole_Rent_a_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {

            double cijena = 0;
            try
            {
                
                int brojDana = Convert.ToInt32(comboBox1.Text);
                if (listBox1.SelectedItem.ToString() == "Gradski")
                {
                    cijena = 150 * brojDana;
                    
                }
                else if (listBox1.SelectedItem.ToString() == "Limuzina")
                {
                    cijena = 250 * brojDana;
                    
                }
                else if (listBox1.SelectedItem.ToString() == "Karavan")
                {
                    cijena = 500 * brojDana;
                    
                }
                else
                    cijena = 0;
            }
            catch (FormatException)
            {

                MessageBox.Show("Unesite ispravan broj!");
            }
            lblShowReturn.Text = $"Ukupna cijena: {cijena:C}";

        }
    }
}
