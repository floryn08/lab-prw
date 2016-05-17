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

namespace lab_17._05._2016
{
    /// <summary>
    /// Interaction logic for Using_the_DataContext.xaml
    /// </summary>
    public partial class Using_the_DataContext : Window
    {
        public Using_the_DataContext()
        {
            InitializeComponent();
            this.DataContext = this;

        }
    }
}
