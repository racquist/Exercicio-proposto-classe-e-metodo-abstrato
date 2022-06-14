namespace Course.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncoming { get; set; }

        protected TaxPayer(string name, double anualIncoming)
        {
            Name = name;
            AnualIncoming = anualIncoming;
        }
        public abstract double AnualTaxes();
    }
}
