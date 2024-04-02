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
using NCKH.View;
namespace NCKH
{
    /// <summary>
    /// Interaction logic for RebarProForm.xaml
    /// </summary>
    public partial class RebarProForm : Window
    {
        
        public static Steels Long_Mat_Bar_Otop { get; set; }
        public static Steels Long_Mat_Bar_Obottom { get; set; }
        public static Steels Con_Mat_Bar { get; set; }
        public static int Long_Size_Bar_Otop { get; set; }
        public static int Long_Size_Bar_Obottom { get; set; }
        public static int Num_Long_Bar_Otop { get; set; }
        public static int Num_Long_Bar_Obottom { get; set; }
        public static double Cover_ForCon { get; set; }
        private CommandModel ViewModel { get; set; }
        public RebarProForm()
        {
            InitializeComponent();
            Long_Mat_Bar_Otop = new Steels();
            Long_Mat_Bar_Obottom = new Steels();
            Con_Mat_Bar = new Steels();
            this.DataContext = ViewModel = new CommandModel();
            txb_Cover_ForCon.PreviewTextInput += NumericTextBox_PreviewTextInput;
            txb_Num_OLong_Bar_Obottom.PreviewTextInput += NumericTextBox_PreviewTextInput;
            txb_Num_OLong_Bar_Otop.PreviewTextInput += NumericTextBox_PreviewTextInput;
            
        }
        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số không
            if (!char.IsDigit(e.Text, e.Text.Length - 1) && e.Text != ".")
            {
                e.Handled = true; // Không cho phép nhập ký tự không hợp lệ
            }
            else
            {
                // Nếu là dấu chấm, kiểm tra xem đã có dấu chấm trong TextBox chưa
                TextBox textBox = sender as TextBox;
                if (e.Text == "." && textBox != null && textBox.Text.Contains("."))
                {
                    e.Handled = true; // Không cho phép nhập nhiều dấu chấm
                }
            }
        }

        private void btn_OK_Click(object sender, RoutedEventArgs e)
        {
            Long_Mat_Bar_Otop = CommandModel.ListSteels.Where(x => x.Name == Cb_Long_Mar_Otop.Text).FirstOrDefault();
            Long_Mat_Bar_Obottom = CommandModel.ListSteels.Where(x => x.Name == Cb_Long_Mar_Obottom.Text).FirstOrDefault();
            Con_Mat_Bar = CommandModel.ListSteels.Where(x => x.Name == Cb_Con_Mar.Text).FirstOrDefault();
            Long_Size_Bar_Otop = int.Parse(Cb_Long_Bar_Size_Otop.Text);
            Long_Size_Bar_Obottom = int.Parse(Cb_Long_Bar_Size_Obottom.Text);
            Num_Long_Bar_Otop = int.Parse(txb_Num_OLong_Bar_Otop.Text);
            Num_Long_Bar_Obottom = int.Parse(txb_Num_OLong_Bar_Obottom.Text);
            Cover_ForCon = double.Parse(txb_Cover_ForCon.Text);
           
            this.Close();
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
