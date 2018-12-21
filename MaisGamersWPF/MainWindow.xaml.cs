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

namespace MaisGamersWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListViewItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            try
            {
                ListViewItem item = (ListViewItem)sender;

                if (item.Name == "listOrcamento")
                {
                    framePrincipal.Source = new Uri("Orcamento.xaml", UriKind.RelativeOrAbsolute);
                }
                else
                {
                    framePrincipal.Source = null;
                }

            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
