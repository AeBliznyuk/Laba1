using System;

namespace Laba1
{   /// <summary>
    /// Класс Animal 
    /// </summary>
    public class Animal:IComparable<Animal>
    {
        /// <summary>
        /// Поле Имя
        /// </summary>
        public string Name;
        /// <summary>
        /// Поле Цвет
        /// </summary>
        public string Color;
        /// <summary>
        /// Поле Возраст
        /// </summary>
        public int Age;
        /// <summary>
        /// Поле Вес
        /// </summary>
        public double Weight;
        /// <summary>
        /// Параметр сравнения
        /// </summary>
        static public string CompareParameter;
        /// <summary>
        /// Метод интерфейса Icomparable для сравнения объектов
        /// </summary>        
        public int CompareTo(Animal other)
        {   
            switch (CompareParameter)
            {
                case "Имя":
                    return this.Name.CompareTo(other.Name);
                case "Возраст":
                    return this.Age.CompareTo(other.Age);
                case "Цвет":
                    return this.Color.CompareTo(other.Color);
                case "Вес":
                    return this.Weight.CompareTo(other.Weight);
                default: throw new Exception("Что-то пошло не так");
            }
                
        }
    }

}
