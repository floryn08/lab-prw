using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab_04._04._2016
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }




        private void btnStergere_Click_1(object sender, RoutedEventArgs e)
        {
            txtCodDep.Text = txtRezultat.Text = String.Empty;
        }

        private void btnAfisare_Click(object sender, RoutedEventArgs e)
        {
            int codDep = Convert.ToInt32(txtCodDep.Text);
            var DE = new Database1Entities();

            var rezultat = (from x in DE.Angajats
                            where x.CodDep == codDep
                            select x).ToList();

            foreach (var item in rezultat)
            {
                txtRezultat.Text += item.Nume + " " + item.Marca + " " + item.Email + " " + item.Salariu + " " + item.Departament.Denumire;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //int codDep = Convert.ToInt32(txtCodDep.Text);
            var DE = new Database1Entities();

            var rez = (from x in DE.Departaments
                       select x).ToList();

            foreach (var item in rez)
            {
                txtRezultat.Text += item.Denumire + " ";
            }


        }
    }
}
