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


namespace Practice_arrayb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchItem_Click(object sender, RoutedEventArgs e)
        {
            int[] itemCode = { 100, 101, 102, 103 };
            string[] fruit = { "Apple", "Orange", "Banana", "Mango" };
            int[] itemPrice = { 2, 3, 4, 5 };
            int searchItem;
            string fruitName = "";
            bool convertInput;
            convertInput = int.TryParse(inPut.Text, out searchItem);
            if (convertInput)
            {
                int CompareResult = 0;
                bool matchSearch = false;
                for (int i = 0; i < itemCode.Length; i++)
                {
                    if (searchItem == itemCode[i])
                    {
                        matchSearch = true;
                        CompareResult = itemPrice[i];
                        fruitName = fruit[i];
                    }
                }
                if (matchSearch)
                    outPut.Content = (searchItem + " is " + fruitName + " Price= " + CompareResult.ToString("C0"));
                else
                    MessageBox.Show("Item not found!");

            }
            else
            {
                MessageBox.Show("Item code is not valid!");
                inPut.Clear();
                inPut.Focus();
            }
        }
    }
}
