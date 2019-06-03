namespace LABA_12
{
    public class ClassBirds : KingdomAnimals
    {
        public bool Flying { get; set; }
        public bool Domestic { get; set; }

        public ClassBirds(bool flying, bool domestic, int weight, string name)
            : base(weight, name)
        {
            Flying = flying;
            Domestic = domestic;
        }
        public override string ToString()
        {
            return $"{Name}, {Weight} кг, летает: {Flying}, домашняя: {Domestic}";
        }
        public KingdomAnimals BaseAnimal
        {
            get
            {
                return new KingdomAnimals(Weight, Name);
            }
        }
    }
}
