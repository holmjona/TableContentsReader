using System;
using System.Collections.Generic;
using System.IO;
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

namespace TableContentsReader {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void BtnSayHello_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Hello"); MessageBox.Show("Hello Again");
        }

        private void  BooDooGoo (object s, RoutedEventArgs e) {
            //MessageBox.Show("Other Button");
            //MessageBox.Show("Other Button");

            //var a = 5;
            //int h;
            //h = 5;

            try {
                MessageBox.Show("Attempt to read");
                string[] chapters = File.ReadAllLines("tocc.txt");
                MessageBox.Show("read successful");

            } catch (Exception ex) {
                MessageBox.Show("oops we had an error: " + ex.Message);

            } finally {
                // always fires
                // close open files.
                MessageBox.Show("In the finally");

            }



        }

   
    }
}
