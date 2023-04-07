using animals_registry;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.Unicode;

List<Pet> animalRegistry = new List<Pet>(); // создаем список для хранения животных в реестре
Counter counter = new Counter(); // создаем объект класса-счетчика

while (true) // бесконечный цикл для работы с программой
{
    Console.WriteLine("\n\nЖивотный реестр");
    Console.WriteLine("1. Добавить новое животное");
    Console.WriteLine("2. Просмотреть список животных");
    Console.WriteLine("3. Найти животное по имени");
    Console.WriteLine("4. Обучить животное новым командам");
    Console.WriteLine("5. Выход");

    Console.Write("Выберите действие: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1: // добавление нового животного в реестр
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите вес: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Введите тип животного (1 - собака, 2 - кошка): ");
            int petType = int.Parse(Console.ReadLine());

            if (petType == 1) // если тип животного - собака
            {
                Console.Write("Введите породу: ");
                string breed = Console.ReadLine();
                animalRegistry.Add(new Dog(name, age, weight, breed));
                //добавляем в список новую собаку
            }
            else if (petType == 2) // если тип животного - кошка
            {
                Console.Write("Введите окрас: ");
                string color = Console.ReadLine();
                animalRegistry.Add(new Cat(name, age, weight, color)); // добавляем в список новую кошку
            }
            else
            {
                Console.WriteLine("Некорректный тип животного. Попробуйте еще раз.");
            }
            break;

        case 2: // вывод списка животных
            Console.WriteLine("Список животных в реестре:");
            foreach (Pet pet in animalRegistry)
            {
                Console.WriteLine(pet);
            }
            break;

        case 3: // поиск животного по имени
            Console.Write("Введите имя животного: ");
            string searchName = Console.ReadLine();
            bool found = false;
            foreach (Pet pet in animalRegistry)
            {
                if (pet.Name == searchName)
                {
                    Console.WriteLine(pet);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Животное с таким именем не найдено.");
            }
            break;

        case 4: // обучение животного новым командам
            Console.Write("Введите имя животного: ");
            string trainName = Console.ReadLine();
            found = false;
            foreach (Pet pet in animalRegistry)
            {
                if (pet.Name == trainName)
                {
                    Console.Write("Введите команду: ");
                    string command = Console.ReadLine();
                    pet.Train(command);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Животное с таким именем не найдено.");
            }
            break;

        case 5: // выход из программы
            Console.WriteLine("До свидания!");
            return;

        default:
            Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
            break;
    }
}
