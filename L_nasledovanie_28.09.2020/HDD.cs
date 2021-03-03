using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_nasledovanie_28._09._2020
{
    class HDD:Storage
    {

        public HDD()
        {
            folder = 0;
        }

        public override void Set_storeg(string name_storeg, string model, int volume)
        {
            this.name_storeg = name_storeg;
            this.model = model;
            this.volume_storage = volume;
        }

        public override void Show_name_storeg()
        {
            Console.WriteLine("Название хранилища :" + name_storeg);
            Console.WriteLine("Название модели :" + model);
            Console.WriteLine("Обьем памяти в Гб :" + volume_storage);
        }
        //создаем имитацию копирования занятого места путем вычетания обьема папки от обьема хранилища
        public override void Copy_folder(int folder)
        {
            if (folder > volume_storage)
            {
                Console.WriteLine("Копирование не возмодно на носителе не достатоно памяти");
            }
            else
            {
                volume_storage -= folder;
            }
        }
        public override void Free_place_on_a_storage()
        {
            Console.WriteLine("Обьем свободной памяти " + name_storeg + ":" + volume_storage);
        }

        public override int Count_device_to_copy(double GB, double MB)
        {
            double result;
            if (volume_storage < GB)
            {
                result = GB / volume_storage;
            }
            else
            {
                result = volume_storage / GB;

            }

            //округлем до целого числа если значение с плавающей точкой
            if ((result - (int)result) != 0)
            {
                result = Math.Ceiling(result);
            }


            Console.WriteLine("Необходимое колличесвто HDD носителей обьемом :" + volume_storage + " Gb" + " ранво :" + result + "шт");


            return (int)result;
        }
    }
}
