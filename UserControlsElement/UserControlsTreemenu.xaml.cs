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
using NCKH.UserControlsElement;
using NCKH.ViewModel;

namespace NCKH.UserControlsElement
{
    /// <summary>
    /// Interaction logic for UserControlsTreemenu.xaml
    /// </summary>
    public partial class UserControlsTreemenu : UserControl
    {
        public UserControlsTreemenu()
        {
            InitializeComponent();
            if (CommandModel.IsUscNode)
            {
                Tab_TreeMenu.SelectedIndex = 0;
                switch (CommandModel.Tab_Index_Nodes)
                {
                    case 0:
                        cb_Nodes.SelectedIndex = 0;
                        UcNode.Children.Clear();
                        UserControl usc_create_node = new UcCreateNode();
                        UcNode.Children.Add(usc_create_node);
                        break;
                    case 1:
                        cb_Nodes.SelectedIndex = 0;
                        UcNode.Children.Clear();
                        UserControl usc_delete_node = new UcCreateNode();
                        UcNode.Children.Add(usc_delete_node);
                        break;
                    default:
                        break;
                }
            }
            if(CommandModel.IsUscElement)
            {
                Tab_TreeMenu.SelectedIndex = 1;
                switch (CommandModel.Tab_Index_Element)
                {
                    case 0:
                        cb_Element.SelectedIndex = 0;
                        UcElement.Children.Clear();
                        UserControl usc_create_element = new UcCreateElement();
                        UcElement.Children.Add(usc_create_element);
                        break;
                    case 1:
                        cb_Element.SelectedIndex = 0;
                        UcElement.Children.Clear();
                        UserControl usc_delete_element = new UcDeleteElement();
                        UcElement.Children.Add(usc_delete_element);
                        break;
                    default:
                        break;
                }
            }    
        }
        private void cb_Nodes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((int)cb_Nodes.SelectedIndex)
            {
                case 0:

                    UcNode.Children.Clear();
                    UserControl usc_create_node = new UcCreateNode();
                    UcNode.Children.Add(usc_create_node);
                    break;
                case 1:

                    UcNode.Children.Clear();
                    UserControl usc_delete_node = new UcDeleteElement();
                    UcNode.Children.Add(usc_delete_node);
                    break;
                default:
                    break;
            }
        }

        private void cb_Element_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((int)cb_Element.SelectedIndex)
            {
                case 0:

                    UcElement.Children.Clear();
                    UserControl usc_create_node = new UcCreateElement();
                    UcElement.Children.Add(usc_create_node);
                    break;
                case 1:

                    UcElement.Children.Clear();
                    UserControl usc_delete_node = new UcDeleteElement();
                    UcElement.Children.Add(usc_delete_node);
                    break;
                default:
                    break;
            }
        }

        private void Tab_TreeMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Tab_TreeMenu.SelectedIndex == 0)
                CommandModel.isClickNode = false;
                CommandModel.isEleFirstNode = false;
                CommandModel.isEleLastNode = false;
            if (Tab_TreeMenu.SelectedIndex == 1)
                CommandModel.isClickNode = false;
                CommandModel.isEleFirstNode = false;
                CommandModel.isEleLastNode = false;
        }
    }
}
