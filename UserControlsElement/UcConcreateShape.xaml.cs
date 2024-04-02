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
using NCKH.ViewModel;

namespace NCKH.UserControlsElement
{
    /// <summary>
    /// Interaction logic for UcConcreateShape.xaml
    /// </summary>
    public partial class UcConcreateShape : UserControl
    {
        public UcConcreateShape()
        {
            InitializeComponent();
        }

        private void Rec_Concreate_Click(object sender, RoutedEventArgs e)
        {
            CommandModel.isRec_Con_Shape = true;
        }
    }
}
