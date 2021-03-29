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
using OperazioniTriangoli;

namespace ClassificazioneTriangoli
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtLato1.Text == "" || txtLato2.Text == "" || txtLato3.Text == "")
            {
                MessageBox.Show("Non sono stati compilati tutti i campi", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                try
                {
                    double lato1 = double.Parse(txtLato1.Text);
                    double lato2 = double.Parse(txtLato2.Text);
                    double lato3 = double.Parse(txtLato3.Text);
                    lblTipoTriangolo.Content = Gestione.Classificazione(lato1, lato2, lato3);
                    lblPerimetro.Content = Gestione.Perimetro(lato1, lato2, lato3);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ ex.Message}", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
