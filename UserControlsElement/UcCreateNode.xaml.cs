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
    /// Interaction logic for UcCreateNode.xaml
    /// </summary>
    public partial class UcCreateNode : UserControl
    {
        private CommandModel viewmodel { get; set; }
        public UcCreateNode()
        {
            InitializeComponent();
            this.DataContext = viewmodel = new CommandModel();
        }

       
        private void Chk_Click_Create_Node_Click(object sender, RoutedEventArgs e)
        {
            if(Chk_Click_Create_Node.IsChecked == true)
            {
                CommandModel.isClickNode = true;
            }
            else
            {
                CommandModel.isClickNode = false;
            }
        }
    }
}
