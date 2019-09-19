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
using System.Windows.Shapes;

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnboton.Click += Btnboton_Click;
        }

        private void Btnboton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaAmigos.Text = "Adios Amigos!";
            lblHolaAmigos.FontSize = 29;
            lblHolaAmigos.Foreground = Brushes.Aqua;
        }

        private void BtnbotonSegundo_Click(object sender, RoutedEventArgs e)
        {
            lblHolaAmigos.Text = "Adios segunda vez";
            lblHolaAmigos.FontSize = 15;
            lblHolaAmigos.Foreground = Brushes.BlueViolet;
        }

        private void BtnbotonTercero_Click(object sender, RoutedEventArgs e)
        {
            lblHolaAmigos.Text = "Adios tercera vez";
            lblHolaAmigos.FontSize = 25;
            lblHolaAmigos.Foreground = Brushes.DarkTurquoise;
        }
    }
}
