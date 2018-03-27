using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppHoofdstuk11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sphere s = new Sphere();
        Bubble b = new Bubble();
        Ball ba = new Ball();

        public MainWindow()
        {
            InitializeComponent();
            b.CreateEllipse(Canvas);
            b.X = 200;
            s.CreateEllipse(Canvas);
            ba.CreateEllipse(Canvas);

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            b.MoveVertical(20);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ba.MoveRight(10);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ba.MoveLeft(10);
        }
    }
}
