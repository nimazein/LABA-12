using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace LABA_12_v2
{
    class TestCollections
    {
        public List<KingdomAnimals> AnimalValue { get; set; }
        public List<string> StringValue { get; set; }
        public Dictionary<KingdomAnimals, ClassMammals> AnimalKeyMammalValue { get; set; }
        public Dictionary<string, ClassMammals> StringKeyMammalValue { get; set; }

        public TestCollections(int size) 
        {
            AnimalValue = new List<KingdomAnimals>(size);
            StringValue = new List<string>(size);
            AnimalKeyMammalValue = new Dictionary<KingdomAnimals, ClassMammals>(size);
            StringKeyMammalValue = new Dictionary<string, ClassMammals>(size);
        }
        public void Add(ClassMammals mammal)
        {
            AnimalValue.Add(mammal.BaseAnimal);
            StringValue.Add(mammal.BaseAnimal.ToString());
            AnimalKeyMammalValue.Add(mammal.BaseAnimal, mammal);
            StringKeyMammalValue.Add(mammal.BaseAnimal.ToString(), mammal);
        }
        public void Remove(ClassMammals mammal)
        {
            AnimalValue.Remove(mammal.BaseAnimal);
            StringValue.Remove(mammal.BaseAnimal.ToString());
            AnimalKeyMammalValue.Remove(mammal.BaseAnimal);
            StringKeyMammalValue.Remove(mammal.BaseAnimal.ToString());
        }
        public void FillRandomly(int numberOfObjects)
        {
            for (int i = 0; i < numberOfObjects; i++)
            {
                Random rnd = new Random();

                int rndIncubationPeriod = rnd.Next(3, 12);
                int rndLifeExpectancy = rnd.Next(5, 120);
                int rndWeight = rnd.Next(1, 150000);
                string name = $"Млекопитающее {i + 1}";

                Add(new ClassMammals(rndIncubationPeriod, rndLifeExpectancy, rndWeight, name));
            }



        }

        public ClassMammals GetByIndex(int index) // why static?
        {
            foreach (var el in StringKeyMammalValue)
            {
                if (GetIndex(el.Value) == index)
                {
                    return el.Value;
                }
            }
            return null;           
        }
        public static ClassMammals GetIntValueReturnMammal(int gg) // Задани е5
        {
            return null;
        }
        private int GetIndex(ClassMammals mammal)
        {
            string key = "";
            foreach (var el in StringKeyMammalValue)
            {
                if (el.Value == mammal)
                {
                    key = el.Key;
                }
            }
            if (key == "")
            {
                throw new IndexNotFoundException("Данный объект не числится в коллекции");
            }

            int i = 0;
            foreach (string el in StringValue)
            {
                if (el == key)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        // Измерить время 
        public void Contains(string value)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            bool contains = StringValue.Contains(value);
            stopWatch.Stop();
            OutputTime(stopWatch);        
        }
        public void Contains(KingdomAnimals value)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            bool contains = AnimalValue.Contains(value);
            stopWatch.Stop();
            OutputTime(stopWatch);
        }
        public void ContainsKey(string key)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            bool contains = StringKeyMammalValue.ContainsKey(key);
            stopWatch.Stop();
            OutputTime(stopWatch);
        }
        public void ContainsKey(KingdomAnimals key)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

             bool contains = AnimalKeyMammalValue.ContainsKey(key);
            stopWatch.Stop();
            OutputTime(stopWatch);
        }
        public void ContainsValue(ClassMammals mammal)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            bool contains = AnimalKeyMammalValue.ContainsValue(mammal);
            stopWatch.Stop();
            OutputTime(stopWatch);
        }
        private void OutputTime(Stopwatch stopWatch)
        {
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:000} тиков",            
                ts.Ticks);
            Console.WriteLine("Time:  " + elapsedTime);
        }
    }
}
