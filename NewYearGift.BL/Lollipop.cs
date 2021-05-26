﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.BL
{
    /// <summary>
    /// Класс леденца
    /// </summary>
    public class Lollipop:SweetBase
    {
        private string _flavor;

        /// <summary>
        /// Вкус 
        /// </summary>
        public string Flavor
        {
            get => _flavor;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вкус леденца не может быть пустым.");
                }

                _flavor = value;
            }
        }
        public Lollipop(string name, string manufacturer, double weight, double sugarWeight, decimal price, string flavor) : base(name, manufacturer, weight, sugarWeight, price)
        {
            Flavor = flavor;
        }
    }
}
