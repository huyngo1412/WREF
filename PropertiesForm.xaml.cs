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
using NCKH.ViewModel;

namespace NCKH
{
    /// <summary>
    /// Interaction logic for PropertiesForm.xaml
    /// </summary>
    public partial class PropertiesForm : Window
    {
        public PropertiesForm()
        {
            InitializeComponent();
            btn_CloseUC_1.Click += Close_Form;
            btn_CloseUC_2.Click += Close_Form;
          

        }
        private void Close_Form(object sender,RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(CommandModel.isMaterial)
            {
                Tab_Material.SelectedIndex = 0;
            }
            if (CommandModel.isSection)
            {
                Tab_Material.SelectedIndex = 1;
            }
        }
    }
}
