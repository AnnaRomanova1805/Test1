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

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login;
            string password;
            login = LoginBox.Text;
            password = PasswordBox.Text;

            if (login == "admin" && password == "admin")
            {
                Window1 window = new Window1();
                window.ShowDialog();
            }
            else
            { 
            MessageBox.Show("Неправильный логин и пароль!", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }




    }
}
