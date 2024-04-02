﻿using System;
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
    /// Interaction logic for UcSteelMat.xaml
    /// </summary>
    public partial class UcSteelMat : UserControl
    {
        public UcSteelMat()
        {
            InitializeComponent();
            txb_Modulus_Steel.PreviewTextInput += NumericTextBox_PreviewTextInput;
            txb_fu.PreviewTextInput += NumericTextBox_PreviewTextInput;
            txb_fy.PreviewTextInput += NumericTextBox_PreviewTextInput;
            txb_Modulus_Steel.TextChanged += TextBox_TextChanged;
            txb_fu.TextChanged += TextBox_TextChanged;
            txb_fy.TextChanged += TextBox_TextChanged;
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             
        }
    }
}
