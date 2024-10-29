using System.Data.Common;
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
using System.Xml.Linq;
using Lib_14;
using System;

namespace практос_6
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
        /// <summary>
        /// метод для выхода из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// метод для информирования о задании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Liquid (жидкость), имеющий поля названия, плотности и объема. Создать необходимые методы и свойства. Создать перегруженные методы SetParams, для установки параметров жидкости.", "Задание", MessageBoxButton.OK, MessageBoxImage.Question);
        }
        /// <summary>
        /// метод для информирования о разработчике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Андрианов Алексей Вариант 14.", "Задание", MessageBoxButton.OK, MessageBoxImage.Question);
        }
        /// <summary>
        /// метод для очистки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            tbDensity1Input.Clear();
            tbName2Input.Clear();
            tbDensityOutput.Clear();
            tbName1Input.Clear();
            tbNameOutput.Clear();
            tbVolume1Input.Clear();
            tbVolumeOutput.Clear();
            tbVolume2Input.Clear();
            tbDensity2Input.Clear();
        }
        Liquid liquid1 = new Liquid();
        Liquid liquid2 = new Liquid();
        bool flagFillFull = false;
        /// <summary>
        /// метод для первоначальной записи характеристик жидкости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbDensity1Input.Text, out int density1) && density1 > 0 && int.TryParse(tbDensity2Input.Text, out int density2) && density2 > 0 && int.TryParse(tbVolume1Input.Text, out int volume1) && volume1 > 0 && int.TryParse(tbVolume2Input.Text, out int volume2) && volume2 > 0 && tbName1Input.Text != "" && tbName2Input.Text != "")
            {
                string name1 = tbName1Input.Text;
                liquid1.SetParams(name1, density1, volume1);
                string name2 = tbName2Input.Text;
                liquid2.SetParams(name2, density2, volume2);
                flagFillFull = true;
                MessageBox.Show("Значения присвоенны", "Выполнено", MessageBoxButton.OK);
            }
            else MessageBox.Show("Введите правильное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// метод для сравнения жидкостей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            if (flagFillFull == true)
            {
                if (liquid1.Name == liquid2.Name && liquid1.Volume == liquid2.Volume)
                {
                    tbCompare.Text = "Жидкости совпадают";
                }
                else tbCompare.Text = "Жидкости не совпадают";
            }
            else MessageBox.Show("Введите характеристики", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// метод для вывода параметров первой жидкости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowLiquid1_Click(object sender, RoutedEventArgs e)
        {
            if (flagFillFull == true)
            {
                tbVolumeOutput.Text = Convert.ToString(liquid1.Volume);
                tbDensityOutput.Text = Convert.ToString(liquid1.Density);
                tbNameOutput.Text = liquid1.Name;
            }
            else MessageBox.Show("Введите характеристики", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// метод для вывода параметров второй жидкости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnShowLiquid2_Click(object sender, RoutedEventArgs e)
        {
            if (flagFillFull == true)
            {
                tbVolumeOutput.Text = Convert.ToString(liquid2.Volume);
                tbDensityOutput.Text = Convert.ToString(liquid2.Density);
                tbNameOutput.Text = liquid2.Name;
            }
            else MessageBox.Show("Введите характеристики", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// метод для увеличения объёма 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncreaseVolume_Click(object sender, RoutedEventArgs e)
        {
            liquid1++;
            liquid2++;
        }
        /// <summary>
        /// метод для уменьшения объёма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReduceVolume_Click(object sender, RoutedEventArgs e)
        {
            if (liquid1.Volume != 0 && liquid2.Volume != 0)
            {
                liquid1--;
                liquid2--;
            }
            else MessageBox.Show("Объём равен 0", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
