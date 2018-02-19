using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aKlient_Click(object sender, EventArgs e)
        {
            if(aPESEL.Text == "PESEL")
            {
                MessageBox.Show("Brak PESELu!");
            }
            else if(Nazwisko.Text == "Nazwisko")
            {
                MessageBox.Show("Brak nazwiska!");
            }
            else if(Imie.Text == "Imie")
            {
                MessageBox.Show("Brak imienia!");
            }
            else if(Miejsce.Text == "Miejsce zamieszkania")
            {
                MessageBox.Show("Brak miejsca zamieszkania!");
            }
            else
            {
                string temp1 = aPESEL.Text;
                string temp2 = Nazwisko.Text;
                string temp3 = Imie.Text;
                string temp4 = Miejsce.Text;

               //IService1.NowyKlient(temp1,temp2,temp3,temp4);

            }
        }
    }
}
