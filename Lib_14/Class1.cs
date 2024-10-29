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
        /// ����� ��� ������������ �������������
        /// </summary>
        /// <param name="name">�������� ��������</param>
        /// <param name="density">��������� ��������</param>
        /// <param name="volume">����� ��������</param>
        public void SetParams(string name, int density, int volume)
        {
            Name = name;
            Density = density;
            Volume = volume;
        }
        /// <summary>
        /// �������� ��� ���������� ������
        /// </summary>
        /// <param name="liquid">������ ������</param>
        /// <returns></returns>
        public static Liquid operator ++(Liquid liquid)
        {
            liquid.Volume += 1;
            return liquid;
        }
        /// <summary>
        /// �������� ��� ���������� ������
        /// </summary>
        /// <param name="liquid">������ ������</param>
        /// <returns></returns>
        public static Liquid operator --(Liquid liquid)
        {
            liquid.Volume -= 1;
            return liquid;
        }
        /// <summary>
        /// �������� ���������
        /// </summary>
        /// <param name="liquid1">������ ������</param>
        /// <param name="liquid2">������ ������</param>
        /// <returns></returns>
        public static bool operator ==(Liquid liquid1, Liquid liquid2)
        {
            if (liquid1.Name == liquid2.Name && liquid1.Volume == liquid2.Volume) return true;
            return false;
        }
        /// <summary>
        /// �������� ���������
        /// </summary>
        /// <param name="liquid1">������ ������</param>
        /// <param name="liquid2">������ ������</param>
        /// <returns></returns>
        public static bool operator !=(Liquid liquid1, Liquid liquid2)
        {
            return false;
        }

    }

}

