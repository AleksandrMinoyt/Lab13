using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Building
    {
        private string _address = "";
        private int _lenght = 0;
        private int _width = 0;
        private int _height = 0;

        public string Address
        {
            get { return _address; }
            set
            {
                if (value.Length > 0)
                {
                    _address = value;
                }
                else
                {
                    throw new Exception("Адрес не может быть пустым");
                }
            }
        }
        public int Lenght
        {
            get { return _lenght; }
            set
            {
                if (value > 0)
                {
                    _lenght = value;
                }
                else
                {
                    throw new Exception("Длина должна быть > 0");
                }
            }
        }
        public int Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("Ширина должна быть > 0");
                }
            }
        }

        public int Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    throw new Exception("Высота должна быть > 0");
                }
            }
        }

        public Building(string Address, int Length, int Width, int Height)
        {
            if (Address.Length > 0)
            {
                _address = Address;
            }
            else
            {
                throw new Exception("Адрес не может быть пустым");
            }

            if (Length > 0)
            {
                _lenght = Length;
            }
            else
            {
                throw new Exception("Длина должна быть > 0");
            }

            if (Width > 0)
            {
                _width = Width;
            }
            else
            {
                throw new Exception("Ширина должна быть > 0");
            }

            if (Height > 0)
            {
                _height = Height;
            }
            else
            {
                throw new Exception("Высота должна быть > 0");
            }
        }
        public void Print()
        {
            Console.WriteLine("Информация о здании");
            Console.WriteLine("Адрес: {0};\nДлина: {1};\nШирина: {2};\nВысота: {3};", _address, _lenght, _width, _height);
        }

    }

   sealed  class MultiBuilding : Building
    {
        private int _storeys = 1;

        public MultiBuilding(string Address, int Length, int Width, int Height, int Storeys)
                    : base(Address, Length, Width, Height)
        {
            if (Storeys > 0)
            {
                _storeys = Storeys;
            }
            else
            {
                throw new Exception("Этажность должна быть > 0");
            }
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Этажность: {0};", _storeys);
        }


    }
}
