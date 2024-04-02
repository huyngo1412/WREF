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
using NCKH.UserControlsElement;
using NCKH.ViewModel;

namespace NCKH
{
    /// <summary>
    /// Interaction logic for SectionFormData.xaml
    /// </summary>
    public partial class SectionFormData : Window
    {
        public SectionFormData()
        {
            InitializeComponent();
            if(CommandModel.isRec_Con_Shape)
            {
                Cb_Section_Shape.SelectedIndex = 0;
            }    
        }

        private void Cb_Section_Shape_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch((int)Cb_Section_Shape.SelectedIndex)
            {
                case 0:
                    CommandModel.isRec_Con_Shape = true;
                    GridShapeType.Children.Clear();
                    UserControl usc = new UcRecConcrete();
                    GridShapeType.Children.Add(usc);
                    break;
                default:
                    break;
            }    
        }

        private void btn_Import_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
