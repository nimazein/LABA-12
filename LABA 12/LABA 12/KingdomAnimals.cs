namespace LABA_12
{
    public class KingdomAnimals
    {
        public int Weight { get; set; }
        public string Name { get; set; }
        public KingdomAnimals(int weight, string name)
        {
            Name = name;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"{Name}, {Weight} кг\n";
        }
    }
}
