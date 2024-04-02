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

namespace NCKH
{
    /// <summary>
    /// Interaction logic for MaterialDataForm.xaml
    /// </summary>
    public partial class MaterialDataForm : Window
    {
        public MaterialDataForm()
        {
            InitializeComponent();
            txb_Id_Mat.PreviewTextInput += NumericTextBox_PreviewTextInput;
        }
        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số không
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c))
                {
                    e.Handled = true; // Nếu không phải là số, không cho phép nhập
                    break;
                }
            }
        }
        private void cb_Mat_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((int)cb_Mat_type.SelectedIndex)
            {
                case 0:
                    Grid_De_Pro_Data.Children.Clear();
                    UserControl usc_Create_Data = new UserControlsElement.UcConcreteMat();
                    Grid_De_Pro_Data.Children.Add(usc_Create_Data);
                    ViewModel.CommandModel.isMatConcreate = true;
                    ViewModel.CommandModel.isMatSteel = false;
                    break;
                case 1:
                    Grid_De_Pro_Data.Children.Clear();
                    UserControl usc_Steel_Data = new UserControlsElement.UcSteelMat();
                    Grid_De_Pro_Data.Children.Add(usc_Steel_Data);
                    ViewModel.CommandModel.isMatConcreate = false;
                    ViewModel.CommandModel.isMatSteel = true;
                    break;
                default:
                    break;
            }
        }

        private void btn_Close_Mat_Form_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Apply_Mat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
