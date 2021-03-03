using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L_nasledovanie_28._09._2020
{
     abstract class Storage
    {
        protected string name_storeg;
        protected string model;
        protected uint folder;//папка для имитирования копирования 
        protected double volume_storage;//обьем носителя
        protected int count_device;//колличесвто неообходимых носителей для переноса 565 гб информации

        public abstract void Set_storeg(string name_storeg, string model,int volume);
        public abstract void Show_name_storeg();
        
        public double volume_storge
        {
            get { return this.volume_storage;}
        }
        public uint Folder
        {

            set {
                folder = value;
                volume_storage -= (int)folder;

            }
            get => folder;

        }

        public abstract void Copy_folder(int folder);

        public abstract void Free_place_on_a_storage();

        public abstract int Count_device_to_copy(double GB, double MB);

    }
}
