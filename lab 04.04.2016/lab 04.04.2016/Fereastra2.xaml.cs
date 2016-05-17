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
    /// Interaction logic for Fereastra2.xaml
    /// </summary>
    public partial class Fereastra2 : Window
    {

        //public MainWindow f1 = new MainWindow();

        public Fereastra2()
        {
            InitializeComponent();
        }



        public bool Adevarat
        {
            get { return chk1.IsChecked.GetValueOrDefault(); }
            set { chk1.IsChecked = value; }
        }

        public DateTime DataNastere
        {
            get { return datePicker.SelectedDate.GetValueOrDefault(Convert.ToDateTime("2016-1-1")); }
            set { datePicker.SelectedDate = value; }
        }

        private ComboBox myVar;

        //public ComboBox Combo
        //{
        //    get
        //    {
        //        if (comboBox.SelectedValue is CheckBox)
        //        {
        //            return comboBox.SelectedValue;
        //        }

        //    }
        //    set
        //    {
        //        if (comboBox.SelectedValue is CheckBox)
        //        {
        //            comboBox.SelectedValue = value;
        //        }

        //    }
        //}
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            wnd2.Close();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
