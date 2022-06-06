using System;
using System.Collections;
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

namespace hashTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            string inputKey = key.Text;
            string inputValue = value.Text;

            hashtable.Add(inputKey, inputValue);
            

        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            string inputKey1 = key.Text;
            hashtable.Remove(inputKey1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ICollection collection = hashtable.Keys;
            foreach(string keyy in collection) 
            {
                string v = (string)hashtable[keyy];

                key.AppendText(keyy);
                value.AppendText(v);


            }
        }
    }
}
