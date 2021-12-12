using System;
using System.IO;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    { 
        /// <summary>
        /// Массив объектов класса Animal
        /// </summary>
        private Animal[] animals;
        /// <summary>
        /// Путь к файлу
        /// </summary>
        private string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\AnimalList.txt";
        
        public Form1()
        {
            InitializeComponent();
            // Значение критерия сравнения по умолчанию
            comboBox1.SelectedItem = "Имя";
            Animal.CompareParameter = comboBox1.SelectedItem.ToString();
            InitAnimals();
            FillListBox(animals);
        }
        /// <summary>
        /// Инициализация массива объектов класса Animal
        /// </summary>
        private void InitAnimals()
        {
            animals = new Animal[15];
            animals[0] = new Animal
            {
                Name = "Голубь",
                Age = 2,
                Weight = 1.8,
                Color = "Белый"
            };
            animals[1] = new Animal()
            {
                Name = "Кот",
                Age = 7,
                Weight = 1.5,
                Color = "Рыжий"
            };
            animals[2] = new Animal()
            {
                Name = "Жираф",
                Age = 5,
                Weight = 100,
                Color = "Коричневый"
            };
            animals[3] = new Animal()
            {
                Name = "Собака",
                Age = 1,
                Weight = 40,
                Color = "Белый"
            };
            animals[4] = new Animal()
            {
                Name = "Бегемот",
                Age = 10,
                Weight = 700,
                Color = "Серый"
            };
            animals[5] = new Animal()
            {
                Name = "Кот",
                Age = 4,
                Weight = 5,
                Color = "Серый"
            };
            animals[6] = new Animal()
            {
                Name = "Попугай",
                Age = 5,
                Weight = 0.1,
                Color = "Розовый"
            };
            animals[7] = new Animal()
            {
                Name = "Собака",
                Age = 11,
                Weight = 20,
                Color = "Коричневый"
            };
            animals[8] = new Animal()
            {
                Name = "Мышь",
                Age = 1,
                Weight = 0.5,
                Color = "Серый"
            };
            animals[9] = new Animal()
            {
                Name = "Кот",
                Age = 8,
                Weight = 4,
                Color = "Бежевый"
            };
            animals[10] = new Animal()
            {
                Name = "Курица",
                Age = 1,
                Weight = 10,
                Color = "Белый"
            };
            animals[11] = new Animal()
            {
                Name = "Собака",
                Age = 4,
                Weight = 20,
                Color = "Коричневый"
            };
            animals[12] = new Animal()
            {
                Name = "Жираф",
                Age = 10,
                Weight = 120,
                Color = "Бежевый"
            };
            animals[13] = new Animal()
            {
                Name = "Курица",
                Age = 3,
                Weight = 3,
                Color = "Рыжий"
            };
            animals[14] = new Animal()
            {
                Name = "Мышь",
                Age = 5,
                Weight = 5,
                Color = "Белый"
            };
        }
        /// <summary>
        /// Заполнение ListBox 1 - 4 
        /// </summary>
        /// <param name="animals">Массив объектов класса Animal, выводимые в ListBox 1 - 4</param>
        private void FillListBox(Animal[] animals)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            foreach (var animal in animals)
            {
                listBox1.Items.Add(animal.Name);
                listBox2.Items.Add(animal.Age);
                listBox3.Items.Add(animal.Weight);
                listBox4.Items.Add(animal.Color);
            }
        }
        /// <summary>
        /// Обработчик изменения параметра сравнения для ComboBox
        /// </summary>        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal.CompareParameter = comboBox1.SelectedItem.ToString();
        }
        /// <summary>
        /// Обработчик нажатия кнопки "Сортировать"
        /// </summary>        
        private void button1_Click(object sender, EventArgs e)
        {            
            Array.Sort(animals);
            FillListBox(animals);
        }
        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить"
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            string content = "";
            foreach(var animal in animals)
            {
                content += $"Имя: {animal.Name}, Возраст: {animal.Age}, Цвет: {animal.Color}, Вес: {animal.Weight}\n";
            }
            File.WriteAllText(filepath, content);
        }
    }
}
