﻿using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.IO;
using System.Windows.Shapes;

namespace lab_04._04._2016
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_afiseaza_Click(object sender, RoutedEventArgs e)
        {
            //lbl_mesaj.Content = "text scris alabala portocala";
            //lbl_mesaj.Content = textBox.Text;

            //lbl_mesaj.Content += string.Format("Prelucrare date: {0}; Citit regulament: {1}", checkBox1.IsChecked, checkBox2.IsChecked);

            lbl_mesaj.Content += string.Format("{0} cu valoarea {1}\n{2} cu valoarea {3}", r1.Content, r1.IsChecked, r2.Content, r2.IsChecked);
            lbl_mesaj1.Content += string.Format("{0} cu valoarea {1}\n{2} cu valoarea {3}", r3.Content, r3.IsChecked, r4.Content, r4.IsChecked);





        }

        private void btn_sterge_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Esti sigur?", "Atentie", MessageBoxButton.YesNo);
            if (mbr == MessageBoxResult.Yes)
            {
                lbl_mesaj.Content = String.Empty;
                textBox.Text = String.Empty;
                txtContinutFisier.Text = String.Empty;

            }
        }



        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (comboBox.SelectedValue is Button)
            {
                lbl_mesaj.Content += "Am slectat din combobox: " + (comboBox.SelectedValue as Button).Content;
            }
            else if (comboBox.SelectedValue is ComboBoxItem)
            {
                lbl_mesaj.Content += "Am slectat din combobox: " + (comboBox.SelectedValue as ComboBoxItem).Content;
            }
            else if (comboBox.SelectedValue is CheckBox)
            {
                lbl_mesaj.Content += "Am slectat din combobox: " + (comboBox.SelectedValue as CheckBox).IsChecked + (comboBox.SelectedValue as CheckBox).Content;
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var mbr = MessageBox.Show("Salvam datele", "Atentie", MessageBoxButton.OKCancel);
            if (mbr == MessageBoxResult.OK)
            {
                wnd1.Title = "salvare date...";
            }
            else
            {
                wnd1.Title = "nu se salveaza...";
            }
        }



        private void Save_Click(object sender, RoutedEventArgs e)
        {

            //save file dialog si sa fie salvat

            var sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter("output.txt")) ;
                {
                    //TODO: write to a txt file
                }
            }

            var mbr = MessageBox.Show("Salvam datele?", "Atentie", MessageBoxButton.OKCancel);
            if (mbr == MessageBoxResult.OK)
            {
                wnd1.Title = "salvare date...";
            }
            else
            {
                wnd1.Title = "nu se salveaza...";
            }

        }

        private void New_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var odf = new OpenFileDialog();
            odf.Filter = "Fisiere text|*.txt|Fisiere XML|*.xml|Fisiere INI|*.ini";
            odf.InitialDirectory = System.IO.Path.GetFullPath(".");

            if (odf.ShowDialog() == true)
            {
                //am selectat un fisier deja > stiu calea completa spre el
                txtContinutFisier.Visibility = Visibility.Visible;

                string caleCompletaFIsier = odf.FileName;

                using (StreamReader sr = new StreamReader(caleCompletaFIsier))
                {

                    txtContinutFisier.Text = sr.ReadToEnd();


                }
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Fereastra2 f2 = new Fereastra2();

            //f2.Show();
            f2.ShowDialog();

            txtChk.Text = f2.Adevarat.ToString();
            txtData.Text = f2.DataNastere.ToString();

            if (f2.comboBox.SelectedValue is Button)
            {
                txtComboBtn.Text = txtComboBtn.Text + "Butonul a fost apasat";

            }

            if (f2.comboBox.SelectedValue is CheckBox)
            {
                //  lbl_mesaj.Content += "Am slectat din combobox: " + (comboBox.SelectedValue as CheckBox).IsChecked + (comboBox.SelectedValue as CheckBox).Content;

                txtComboChk.Text += (f2.comboBox.SelectedValue as CheckBox).IsChecked.ToString();
            }

        }
    }
}