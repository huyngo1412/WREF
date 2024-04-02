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
    /// Interaction logic for DesignLoadForm.xaml
    /// </summary>
    public partial class DesignLoadForm : Window
    {
        private CommandModel viewmodel { get; set; }
        public DesignLoadForm()
        {
            InitializeComponent();
            this.DataContext = viewmodel = new CommandModel();
            txb_a1.PreviewTextInput += NumericTextBox_PreviewTextInput;
            Point FirstPoint = CommandModel.ListEle.Where(x => x.Name == CommandModel.ChooseEle).Select(x => x.FirstNode.Center).FirstOrDefault();
            Point SecondPoint = CommandModel.ListEle.Where(x => x.Name == CommandModel.ChooseEle).Select(x => x.SecondNode.Center).FirstOrDefault();
            double Length = Math.Sqrt(Math.Pow(FirstPoint.X - SecondPoint.X, 2) + Math.Pow(FirstPoint.Y - SecondPoint.Y, 2));
            tb_Length.Text = Length.ToString();
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
        private void CloseForm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
