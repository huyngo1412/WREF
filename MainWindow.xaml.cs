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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HelixToolkit.Wpf;
using LiveCharts;
using LiveCharts.Wpf;
using NCKH.UserControlsElement;
using NCKH.ViewModel;
using NCKH.View;
namespace NCKH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private int isMouseDownCanvas = 0;
        private CommandModel ViewModel { get; set; }
        UserControl uscnode ;
        public SeriesCollection SeriesCollection { get; set; }

        public MainWindow()
        {
            InitializeComponent();
           


            this.DataContext = ViewModel = new CommandModel();         
        }  
        private void CreateNode_Click(object sender, RoutedEventArgs e)
        {
            CommandModel.IsUscNode = true;
            CommandModel.IsUscElement = false;
            CommandModel.Tab_Index_Nodes = 0;
        }
        private void DeleteNode_Click(object sender, RoutedEventArgs e)
        {
            CommandModel.IsUscNode = true;
            CommandModel.IsUscElement = false;
            CommandModel.Tab_Index_Nodes = 1;
        }
        private void CreateElement_Click(object sender, RoutedEventArgs e)
        {
            CommandModel.IsUscNode = false;
            CommandModel.IsUscElement = true;
            CommandModel.Tab_Index_Element = 0;
        }
        private void DeleteElement_Click(object sender, RoutedEventArgs e)
        {
            CommandModel.IsUscNode = false;
            CommandModel.IsUscElement = true;
            CommandModel.Tab_Index_Element = 1;
        }
        private void Design_Material_Click(object sender, RoutedEventArgs e)
        {
            CommandModel.isMaterial = true;
            CommandModel.isSection = false;
        }
        private void Design_Section_Click(object sender, RoutedEventArgs e)
        {
            CommandModel.isMaterial = false;
            CommandModel.isSection = true;
        }
        private void Design_Load_Click(object sender, RoutedEventArgs e)
        {
            CommandModel.isDesignLoad = true;
            MessageBox.Show("Please select an element");
        }

        private void Grid_Canvas_MouseMove(object sender, MouseEventArgs e)
        {
           
             Point position = e.GetPosition(Grid_Canvas);
            double mouseX = position.X;
            double mouseY = position.Y;
            tb_Location.Text = "Position X = " + mouseX / CommandModel.Scale + ", Y = " + mouseY / CommandModel.Scale;
            CommandModel.Position.Clear();
            CommandModel.Position.Add(mouseX / CommandModel.Scale + ", " + mouseY / CommandModel.Scale);
        }

       

        private void Grid_Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                Point PosMouse = e.GetPosition(Grid_Canvas) ;
                if(CommandModel.isDesignLoad == true)
                {
                    CommandModel.isClickNode = false;
                    CommandModel.isEleFirstNode = false;
                    CommandModel.isEleLastNode = false;
                    bool isSelect = false;
                    ViewFrame.Children.Clear();
                    foreach (var item in CommandModel.ListNode)
                    {
                        ViewFrame.Children.Add(item.Cir);
                    }
                    foreach (var item in CommandModel.ListEle)
                    {
                        if(item.FirstNode.Center.X != item.SecondNode.Center.X && item.FirstNode.Center.Y != item.SecondNode.Center.Y)
                        {
                            double A = (PosMouse.X - item.FirstNode.Center.X * CommandModel.Scale) / (CommandModel.Scale*(item.SecondNode.Center.X - item.FirstNode.Center.X));
                            double B = (PosMouse.Y - item.FirstNode.Center.Y * CommandModel.Scale) / (CommandModel.Scale * (item.SecondNode.Center.Y - item.FirstNode.Center.Y));
                            if(Math.Abs(A - B) < 0.05)
                            {
                                ViewFrame.Children.Add(CommandModel.CreateLineMethod(new Point(item.FirstNode.Center.X * CommandModel.Scale, item.FirstNode.Center.Y * CommandModel.Scale),
                                    new Point(item.SecondNode.Center.X * CommandModel.Scale, item.SecondNode.Center.Y * CommandModel.Scale), Brushes.Red));
                                isSelect = true;
                                CommandModel.ChooseEle = item.Name;
                            }    
                            else
                            {
                                ViewFrame.Children.Add(CommandModel.CreateLineMethod(new Point(item.FirstNode.Center.X * CommandModel.Scale, item.FirstNode.Center.Y * CommandModel.Scale),
                                       new Point(item.SecondNode.Center.X * CommandModel.Scale, item.SecondNode.Center.Y * CommandModel.Scale), Brushes.Blue));
                            }    
                        }   
                        else if(item.FirstNode.Center.X == item.SecondNode.Center.X)
                        {
                            if (Math.Abs(PosMouse.X - item.FirstNode.Center.X * CommandModel.Scale) < 1 && PosMouse.Y <= Math.Max(item.FirstNode.Center.Y * CommandModel.Scale, item.SecondNode.Center.Y * CommandModel.Scale)
                                && PosMouse.Y >= Math.Min(item.FirstNode.Center.Y * CommandModel.Scale, item.SecondNode.Center.Y * CommandModel.Scale))
                            {
                                ViewFrame.Children.Add(CommandModel.CreateLineMethod(new Point(item.FirstNode.Center.X * CommandModel.Scale, item.FirstNode.Center.Y * CommandModel.Scale),
                                    new Point(item.SecondNode.Center.X * CommandModel.Scale, item.SecondNode.Center.Y * CommandModel.Scale), Brushes.Red));
                                isSelect = true;
                                CommandModel.ChooseEle = item.Name;
                            }
                            else
                            {
                                ViewFrame.Children.Add(CommandModel.CreateLineMethod(new Point(item.FirstNode.Center.X * CommandModel.Scale, item.FirstNode.Center.Y * CommandModel.Scale),
                                       new Point(item.SecondNode.Center.X * CommandModel.Scale, item.SecondNode.Center.Y * CommandModel.Scale), Brushes.Blue));
                            }
                        }   
                        else if(item.FirstNode.Center.Y == item.SecondNode.Center.Y)
                        {
                            if (Math.Abs(PosMouse.Y - item.FirstNode.Center.Y * CommandModel.Scale) < 1 && PosMouse.X <= Math.Max(item.FirstNode.Center.X * CommandModel.Scale, item.SecondNode.Center.X * CommandModel.Scale)
                               && PosMouse.X >= Math.Min(item.FirstNode.Center.X * CommandModel.Scale, item.SecondNode.Center.X * CommandModel.Scale))
                            {
                                ViewFrame.Children.Add(CommandModel.CreateLineMethod(new Point(item.FirstNode.Center.X * CommandModel.Scale, item.FirstNode.Center.Y * CommandModel.Scale),
                                    new Point(item.SecondNode.Center.X * CommandModel.Scale, item.SecondNode.Center.Y * CommandModel.Scale), Brushes.Red));
                                isSelect = true;
                                CommandModel.ChooseEle = item.Name;
                            }
                            else
                            {
                                ViewFrame.Children.Add(CommandModel.CreateLineMethod(new Point(item.FirstNode.Center.X * CommandModel.Scale, item.FirstNode.Center.Y * CommandModel.Scale),
                                       new Point(item.SecondNode.Center.X * CommandModel.Scale, item.SecondNode.Center.Y * CommandModel.Scale), Brushes.Blue));
                            }
                        }
                    }
                     
                    if (isSelect == true)
                    {
                        DesignLoadForm designLoadForm = new DesignLoadForm();
                        designLoadForm.ShowDialog();
                    }    
                   
                    
                }    
                if (CommandModel.isClickNode == true)
                {
                    CommandModel.isEleFirstNode = false;
                    CommandModel.isEleLastNode = false;
                    ViewFrame.Children.Clear();
                    CommandModel.IDNode += 1;
                    Nodes node = new Nodes
                    {
                        ID = CommandModel.IDNode,
                        Cir = CommandModel.CreateNodeMethod(PosMouse),
                        Center = new Point(PosMouse.X/CommandModel.Scale, PosMouse.Y / CommandModel.Scale)
                    };
                    CommandModel.ListNode.Add(node);
                    foreach (var item in CommandModel.ListNode)
                    {
                        ViewFrame.Children.Add(item.Cir);
                    }
                    foreach (var item in CommandModel.ListEle)
                    {
                        ViewFrame.Children.Add(CommandModel.CreateLineMethod(new Point(item.LineEle.X1 * CommandModel.Scale, item.LineEle.Y1 * CommandModel.Scale), new Point(item.LineEle.X2 * CommandModel.Scale, item.LineEle.Y2 * CommandModel.Scale),Brushes.Blue));
                    }
                }
                if (CommandModel.isEleFirstNode == true)
                {

                    ViewFrame.Children.Clear();
                    foreach (var item in CommandModel.ListNode)
                    {
                        item.Cir.Fill = Brushes.Blue;
                        if (Math.Abs(item.Center.X * CommandModel.Scale - PosMouse.X ) <= item.Cir.Width && Math.Abs(item.Center.Y * CommandModel.Scale - PosMouse.Y) <= item.Cir.Height)
                        {
                            item.Cir.Fill = Brushes.Red;
                            CommandModel.PointNodeF.Clear();
                            CommandModel.PointNodeF.Add(item.Center.X + "," + item.Center.Y );
                        }
                        ViewFrame.Children.Add(item.Cir);

                    }
                    foreach (var item in CommandModel.ListEle)
                    {
                        ViewFrame.Children.Add(CommandModel.CreateLineMethod(new Point(item.LineEle.X1 * CommandModel.Scale, item.LineEle.Y1 * CommandModel.Scale),new Point(item.LineEle.X2 * CommandModel.Scale, item.LineEle.Y2 * CommandModel.Scale), Brushes.Blue));
                    }
                }
                if (CommandModel.isEleLastNode == true)
                {

                    ViewFrame.Children.Clear();
                    foreach (var item in CommandModel.ListNode)
                    {
                        item.Cir.Fill = Brushes.Blue;
                        if (Math.Abs(item.Center.X * CommandModel.Scale - PosMouse.X ) <= item.Cir.Width && Math.Abs(item.Center.Y * CommandModel.Scale - PosMouse.Y) <= item.Cir.Height)
                        {
                            item.Cir.Fill = Brushes.Red;
                            CommandModel.PointNodeL.Clear();
                            CommandModel.PointNodeL.Add(item.Center.X + "," + item.Center.Y );
                        }
                        ViewFrame.Children.Add(item.Cir);
                    }
                    foreach (var item in CommandModel.ListEle)
                    {
                        ViewFrame.Children.Add(CommandModel.CreateLineMethod(new Point(item.LineEle.X1 * CommandModel.Scale, item.LineEle.Y1 * CommandModel.Scale), new Point(item.LineEle.X2 * CommandModel.Scale, item.LineEle.Y2 * CommandModel.Scale), Brushes.Blue));

                    }
                }
            }    
            
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                ViewFrame.Children.Clear();
                foreach (var item in CommandModel.ListNode)
                {
                    item.Cir.Fill = Brushes.Blue;
                    ViewFrame.Children.Add(item.Cir);
                }
                foreach (var item in CommandModel.ListEle)
                {
                    item.LineEle.Fill = Brushes.Blue;
                    item.LineEle.Stroke = Brushes.Blue;
                    ViewFrame.Children.Add(item.LineEle);
                }
            }
        }

        private void Cb_Unit_Length_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Cb_Unit_Length.SelectedIndex)
            {
                case 0:
                    CommandModel.Scale = 0.1;
                    break;
                case 1:
                    CommandModel.Scale = 0.01;
                    break;
                case 2:
                    CommandModel.Scale = 0.001;
                    break;
                default:
                    break;
            }
        }

        private void MenuItem_RunAna_Click(object sender, RoutedEventArgs e)
        {
            if(CommandModel.RunAna == true)
            {
                Tab_Frame.SelectedIndex = 1;
            }    
        }
    }
}
