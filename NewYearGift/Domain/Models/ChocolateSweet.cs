﻿namespace NewYearGift.Domain.Models
{
    /// <summary>
    /// Класс шоколадной конфеты
    /// </summary>
    public class ChocolateSweet : Sweet
    {
        /// <summary>
        /// Тип шоколада
        /// </summary>
        public string KindOfChocolate { get; set; }
        
        public override string ToString()
        {
            return
                $"Id: {Id}, Шоколадная конфета: {Name}, Производитель: {Manufacturer}, Вес: {Weight} г., Кол-во сахара: {SugarWeight} г., Стоимость: {Price:C1}, Шоколад: {KindOfChocolate}";
        }
    }
}