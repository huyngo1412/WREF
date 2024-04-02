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

namespace NCKH
{
    /// <summary>
    /// Interaction logic for ShapeForm.xaml
    /// </summary>
    public partial class ShapeForm : Window
    {
        public ShapeForm()
        {
            InitializeComponent();
        }

        private void Cb_Shape_Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch((int)Cb_Shape_Type.SelectedIndex)
            {
                case 0:
                    Grid_Shape_Type.Children.Clear();
                    UserControl usc_Concreate = new UcConcreateShape();
                    Grid_Shape_Type.Children.Add(usc_Concreate);
                    break;
                case 1:
                    Grid_Shape_Type.Children.Clear();
                    UserControl usc_Steel = new UcSteelShape();
                    Grid_Shape_Type.Children.Add(usc_Steel);
                    break;
                default:
                    break;
            }    
        }
    }
    
}
