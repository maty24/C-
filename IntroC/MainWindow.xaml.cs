﻿using System;
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
using System.Windows.Shapes;

namespace IntroC
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

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            string textoAltura = txtAltura.Text;//estamos obteniendo el texto
            double altura = Double.Parse(textoAltura);//esto combierte en un numero

            string textoPeso = txtPeso.Text;
            double peso = Double.Parse(textoPeso);

            double imc = peso / (altura * peso);//acepta numeros decimales

            MessageBox.Show("El IMC: " + imc);
        }
    }
}
