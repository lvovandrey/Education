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

namespace EF_codeFirst
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
            using (UserContext db = new UserContext())
            {
                // создаем два объекта User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Sam", Age = 26 };
                user1.City = new city { Name = "Moskow", CitizenCount = 100 };
                user2.City = new city { Name = "Paris", CitizenCount = 120 };
                user1.Money = new money { type = "cash", count = 10 };
                user2.Money = new money { type = "bank", count = 12 };

                // добавляем их в бд
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                L1.Items.Add("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Users;
                L1.Items.Add("Список объектов:");
                foreach (User u in users)
                {
                    L1.Items.Add(string.Format("{0}.{1} - {2}", u.Id, u.Name, u.Age));
                }
            }
        }
    }
}
