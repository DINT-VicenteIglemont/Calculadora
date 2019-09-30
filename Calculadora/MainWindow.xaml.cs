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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Operando2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Operar();
        }

        private void Operando1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Operar();
        }

        public void Operar()
        {
            try
            {
                if(Operando1TextBox != null && Operando2TextBox != null && ResultadoTextBox != null)
                {
                    int operando1 = int.Parse(Operando1TextBox.Text);
                    int operando2 = int.Parse(Operando2TextBox.Text);

                    if (SumaRadioButton.IsChecked == true)
                    {
                        ResultadoTextBox.Text = (operando1 + operando2).ToString();
                    }
                    else if (RestaRadioButton.IsChecked == true)
                    {
                        ResultadoTextBox.Text = (operando1 - operando2).ToString();
                    }
                    else if (MultiplicacionRadioButton.IsChecked == true)
                    {
                        ResultadoTextBox.Text = (operando1 * operando2).ToString();
                    }
                    else if (DivisionRadioButton.IsChecked == true)
                    {
                        ResultadoTextBox.Text = (operando1 / operando2).ToString();
                    }
                }
            }
            catch (FormatException e)
            {
                ResultadoTextBox.Text = e.Message;
            }
            catch(DivideByZeroException e)
            {
                ResultadoTextBox.Text = e.Message;
            }
            
        }

        private void SumaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Operar();
        }

        private void RestaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Operar();
        }

        private void MultiplicacionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Operar();
        }

        private void DivisionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Operar();
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Text = "0";
            Operando2TextBox.Text = "0";
            ResultadoTextBox.Text = "0";

            SumaRadioButton.IsChecked = true;
        }
    }
}
