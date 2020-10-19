using System;
using System.Windows;
using System.Windows.Controls;

namespace Ejercicio4
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

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            caracteresTextBlock.Text =textoTextBox.Text.Length+"/140";
            if (textoTextBox.Text.Length == 140) textoTextBox.IsReadOnly = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textoTextBox.IsReadOnly = false;
            textoTextBox.Text = "";
        }
    }
}
