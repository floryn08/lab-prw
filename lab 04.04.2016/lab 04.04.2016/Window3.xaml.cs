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
        Database1Entities DECtx;
        public List<Departament> ListaDepartamente { get; set; }
        public List<Angajat> ListaAngajati { get; set; }

        public Window3()
        {
            InitializeComponent();

            DECtx = new Database1Entities();

            ListaDepartamente = new List<Departament>(DECtx.Departaments);

            DataContext = this;
        }

        private void btnStergere_Click_1(object sender, RoutedEventArgs e)
        {
            //txtCodDep.Text = txtRezultat.Text = String.Empty;
        }

        private void btnAfisare_Click(object sender, RoutedEventArgs e)
        {
            //int codDep = Convert.ToInt32(txtCodDep.Text);

            //AfisareAngajati(codDep);

            Window4 wnd4 = new Window4();

            wnd4.ShowDialog();
        }

        private void AfisareAngajati(int codDep)
        {
            var rezultat = (from x in DECtx.Angajats
                            where x.CodDep == codDep
                            select x).ToList();

            ListaAngajati = rezultat;
            comboBoxAngajat.Items.Clear();
            foreach (var item in rezultat)
            {
                //txtRezultat.Text += item.Nume + " " + item.Marca + " " + item.Email + " " + item.Salariu + " " + item.Departament.Denumire + "\n";
                comboBoxAngajat.Items.Add(new ComboBoxItem() { Content = item.Nume });
            }
        }

        //public void EditareAngajati(String nume)
        //{
        //    Window4 wnd4 = new Window4();


        //    var rezultat = (from x in DECtx.Angajats
        //                    where x.Nume == nume
        //                    select x).ToList();


        //    foreach (var item in rezultat)
        //    {
                
        //        wnd4.tbNume.Text += item.Nume.ToString();

        //    }

        //}


        private void button_Click(object sender, RoutedEventArgs e)
        {


            //var rez = (from x in DECtx.Departaments
            //           select x).ToList();

            //foreach (var item in rez)
            //{
            //    txtRezultat.Text += item.Denumire + "\n";
            //}


        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var DepSelectat = comboBoxDep.SelectedValue as Departament;

            //txtRezultat.Text = String.Empty;

            AfisareAngajati(DepSelectat.CodDep);
        }

        private void comboBoxAngajat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Window4 wnd4 = new Window4();

            var MarcaAng = comboBoxAngajat.SelectedValue as Angajat;

            //EditareAngajati(MarcaAng.Nume);

            wnd4.Show();








        }
    }
}
