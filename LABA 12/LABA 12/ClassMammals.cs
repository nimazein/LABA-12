namespace LABA_12
{
    public class ClassMammals : KingdomAnimals
    {
        public int IncubationPeriod { get; set; }
        public int LifeExpectancy { get; set; }

        public ClassMammals(int incubationPeriod, int lifeExpectancy, int weight, string name)
            : base(weight, name)
        {
            IncubationPeriod = incubationPeriod;
            LifeExpectancy = lifeExpectancy;
        }
        public override string ToString()
        {
            return $"{Name}, {Weight} кг, {IncubationPeriod} месяцев, {LifeExpectancy} лет\n";
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
