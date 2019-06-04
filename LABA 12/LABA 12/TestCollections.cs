using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_12
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
        public ClassMammals GetByIndex(int index)
        {
            index -= 1;
            foreach (var el in StringKeyMammalValue)
            {
                if (GetIndex(el.Value) == index)
                {
                    return el.Value;
                }
            }
            return null;           
        }
        public int GetIndex(ClassMammals mammal)
        {
            string key = "";
            foreach (var el in StringKeyMammalValue)
            {
                if (el.Value == mammal)
                {
                    key = el.Key;
                }
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
    }
}
