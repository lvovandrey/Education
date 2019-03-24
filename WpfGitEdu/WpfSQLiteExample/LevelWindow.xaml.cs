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
using System.Windows.Shapes;

namespace WpfSQLiteExample
{
    /// <summary>
    /// Логика взаимодействия для LevelWindow.xaml
    /// </summary>
    public partial class LevelWindow : Window
    {
        public Level Level { get; private set; }

        public LevelWindow(Level p)
        {
            InitializeComponent();
            Level = p;
            this.DataContext = Level;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}

