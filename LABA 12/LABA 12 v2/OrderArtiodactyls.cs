namespace LABA_12_v2
{
    public class OrderArtiodactyls : ClassMammals
    {
        public bool HasHorns { get; set; }
        public string Habitat { get; set; }
        public OrderArtiodactyls(bool hasHorns, string habitat, int incubationPeriod, int lifeExpectancy, int weight, string name)
            : base(incubationPeriod, lifeExpectancy, weight, name)
        {
            HasHorns = hasHorns;
            Habitat = habitat;
        }

        public override string ToString()
        {
            return $"{Name}, {Weight} кг, {IncubationPeriod} месяцев, {LifeExpectancy} лет, есть рога: {HasHorns}, {Habitat}\n";
        }
        public ClassMammals BaseMammal
        {
            get
            {
                return new ClassMammals(IncubationPeriod, LifeExpectancy, Weight, Name);
            }
        }

    }
}
