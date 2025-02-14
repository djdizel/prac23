﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac23
{
    internal class Rectangle
    {
        /// <summary>
        /// Объявление полей
        /// </summary>
        private double length;
        private double width;
        /// <summary>
        /// Инкапсуляция полей
        /// </summary>
        public double Length { get => length; 
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                length = value;
            }
        }
        public double Width { get => width; 
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                width = value;
            }
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Rectangle() { }
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="field1"></param>
        public Rectangle(double length,double width)
        {
            this.Length = length;
            this.Width = width;
        }

        /// <summary>
        /// Функция формирования строки с информацией об объекте
        /// </summary>
        public override string ToString()
        {
            return $"Length = {Length}, Width = {Width}";
        }
    }
}
