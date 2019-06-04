using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_12_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Размер коллекции: ");

            int size = 0;
            try
            {
                size = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода");
            }

            TestCollections collections = new TestCollections(size);
            Console.WriteLine("Коллекция создана");
            Console.WriteLine();

            Console.WriteLine("Заполним коллекцию!");
            Console.Write("Желаемое количество объектов: ");

            int numberOfObjects = 0;
            try
            {
                numberOfObjects = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода");
            }
            if (numberOfObjects > size)
            {
                throw new OutOfRangeException("В коллекцию не поместится столько объектов");
            }

            collections.FillRandomly(numberOfObjects);
            Console.WriteLine("Коллекция заполнена");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Тестирование метода Contains для коллекции StringValue");
            Console.WriteLine();
            Console.WriteLine("Время поиска первого элемента: ");
            collections.Contains(collections.StringValue[0]);

            Console.WriteLine("Время поиска среднего элемента: ");
            collections.Contains(collections.StringValue[numberOfObjects / 2]);

            Console.WriteLine("Время поиска последнего элемента: ");
            collections.Contains(collections.StringValue[numberOfObjects - 1]);

            Console.WriteLine("Время поиска несуществующего элемента: ");
            collections.Contains("я строка");
            Console.ReadKey();



            Console.WriteLine("Тестирование метода Contains для коллекции AnimalValue");
            Console.WriteLine();
            Console.WriteLine("Время поиска первого элемента: ");
            collections.Contains(collections.AnimalValue[0]);

            Console.WriteLine("Время поиска среднего элемента: ");
            collections.Contains(collections.AnimalValue[numberOfObjects / 2]);

            Console.WriteLine("Время поиска последнего элемента: ");
            collections.Contains(collections.AnimalValue[numberOfObjects - 1]);

            Console.WriteLine("Время поиска несуществующего элемента: ");
            collections.Contains(new KingdomAnimals(80, "Человек"));
            Console.ReadKey();



            Console.WriteLine("Тестирование метода ContainsKey для коллекции StringKeyMammalValue");
            Console.WriteLine();
            Console.WriteLine("Время поиска первого элемента: ");
            collections.ContainsKey(collections.StringValue[0]);
           
            Console.WriteLine("Время поиска среднего элемента: ");
            collections.ContainsKey(collections.StringValue[numberOfObjects / 2]);

            Console.WriteLine("Время поиска последнего элемента: ");
            collections.ContainsKey(collections.StringValue[numberOfObjects - 1]);

            Console.WriteLine("Время поиска несуществующего элемента: ");
            collections.ContainsKey("я строка");
            Console.ReadKey();



            Console.WriteLine("Тестирование метода ContainsKey для коллекции AnimalKeyMammalValue");
            Console.WriteLine();
            Console.WriteLine("Время поиска первого элемента: ");
            collections.ContainsKey(collections.AnimalValue[0]);

            Console.WriteLine("Время поиска среднего элемента: ");
            collections.ContainsKey(collections.AnimalValue[numberOfObjects / 2]);

            Console.WriteLine("Время поиска последнего элемента: ");
            collections.ContainsKey(collections.AnimalValue[numberOfObjects - 1]);

            Console.WriteLine("Время поиска несуществующего элемента: ");
            collections.ContainsKey(new KingdomAnimals(80, "Человек"));
            Console.ReadKey();


            

            Console.WriteLine("Тестирование метода ContainsValue для коллекции AnimalKeyMammalValue");
            Console.WriteLine();
            Console.WriteLine("Время поиска первого элемента: ");

            string key = collections.StringValue[0];
            collections.ContainsValue(collections.StringKeyMammalValue[key]);

            

            Console.WriteLine("Время поиска среднего элемента: ");
            string keyMiddle = collections.StringValue[numberOfObjects / 2];
            collections.ContainsValue(collections.StringKeyMammalValue[keyMiddle]);

            Console.WriteLine("Время поиска последнего элемента: ");
            string keyEnd = collections.StringValue[numberOfObjects - 1];
            collections.ContainsValue(collections.StringKeyMammalValue[keyEnd]);

            Console.WriteLine("Время поиска несуществующего элемента: ");
            collections.ContainsValue(new ClassMammals(7,12,5,"Кошка"));
            Console.ReadKey();








        }
    }
}
