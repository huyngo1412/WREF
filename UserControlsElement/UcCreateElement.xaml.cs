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
using NCKH.View;
namespace NCKH.UserControlsElement
{
    /// <summary>
    /// Interaction logic for UcCreateElement.xaml
    /// </summary>
    public partial class UcCreateElement : UserControl
    {
        private CommandModel ViewModel { get; set; }
        public UcCreateElement()
        {
            InitializeComponent();
            this.DataContext = ViewModel = new CommandModel();
           
        }

      
        

        private void txb_First_Node_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txb_First_Node.IsFocused == true)
                CommandModel.isEleFirstNode = true;
                CommandModel.isEleLastNode = false;
        }

        private void txb_Last_Node_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txb_Last_Node.IsFocused == true)
                CommandModel.isEleLastNode = true;
                CommandModel.isEleFirstNode = false;
            
        }
    }
}
