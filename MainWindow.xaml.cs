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

namespace Exam
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
            using(var db = new UsersEntities())
            {
               

                var pass = db.all.AsNoTracking().FirstOrDefault(u => u.login == textBoxLogin.Text && u.password == passBox.Password);

                 // Каждый пользователь входит на свою страницу
                if(pass.login == "ID1518" && pass.password == "111")
                {
                    this.Hide();
                    var window = new Window();
                    window.Content = new Page1();
                    window.Show();
                }

                if (pass.login == "ID1526" && pass.password == "123")
                {
                    this.Hide();
                    var window = new Window();
                    window.Content = new Page2();
                    window.Show();
                }
                if (pass.login == "ID1527" && pass.password == "222")
                {
                    this.Hide();
                    var window = new Window();
                    window.Content = new Page3();
                    window.Show();
                }
                if (pass.login == "ID1534" && pass.password == "333")
                {
                    this.Hide();
                    var window = new Window();
                    window.Content = new Page4();
                    window.Show();
                }
                if (pass.login == "ID1535" && pass.password == "444")
                {
                    this.Hide();
                    var window = new Window();
                    window.Content = new Page5();
                    window.Show();
                }
                else 
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
                


            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
