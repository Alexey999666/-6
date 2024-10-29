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

namespace Lib_14
{

    
    public class Liquid
    {
        public string Name { get; set; }
        public int Density { get; set; }
        public int Volume { get; set; }
        /// <summary>
        /// метод для присваивания характеристик
        /// </summary>
        /// <param name="name">название жидкости</param>
        /// <param name="density">плотность жидкости</param>
        /// <param name="volume">объём жидкости</param>
        public void SetParams(string name, int density, int volume)
        {
            Name = name;
            Density = density;
            Volume = volume;
        }
        /// <summary>
        /// оператор для увеличения объёма
        /// </summary>
        /// <param name="liquid">объект класса</param>
        /// <returns></returns>
        public static Liquid operator ++(Liquid liquid)
        {
            liquid.Volume += 1;
            return liquid;
        }
        /// <summary>
        /// оператор для уменьшения объёма
        /// </summary>
        /// <param name="liquid">объект класса</param>
        /// <returns></returns>
        public static Liquid operator --(Liquid liquid)
        {
            liquid.Volume -= 1;
            return liquid;
        }
        /// <summary>
        /// оператор сравнения
        /// </summary>
        /// <param name="liquid1">объект класса</param>
        /// <param name="liquid2">объект класса</param>
        /// <returns></returns>
        public static bool operator ==(Liquid liquid1, Liquid liquid2)
        {
            if (liquid1.Name == liquid2.Name && liquid1.Volume == liquid2.Volume) return true;
            return false;
        }
        /// <summary>
        /// оператор сравнения
        /// </summary>
        /// <param name="liquid1">объект класса</param>
        /// <param name="liquid2">объект класса</param>
        /// <returns></returns>
        public static bool operator !=(Liquid liquid1, Liquid liquid2)
        {
            return false;
        }

    }

}

