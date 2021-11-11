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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM vm = new MainWindowVM();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;

        }

        private void FlechaIzquierda_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            vm.Retroceder();
        }

        private void FlechaDerecha_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            vm.Avanzar();
        }
    }
}

