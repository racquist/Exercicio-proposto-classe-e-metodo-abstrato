

namespace Course.Entities
{
    class Company : TaxPayer
    {
        public int Employees { get; set; }

        public Company(string name, double anualIncoming, int employees) : base(name, anualIncoming)
        {
            Employees = employees;
        }
        public override double AnualTaxes()
        {
            if(Employees > 10)
            {
                return AnualIncoming * 0.14;
            }
            else
            {
                return AnualIncoming * 0.16;
            }
        }
    }
}
