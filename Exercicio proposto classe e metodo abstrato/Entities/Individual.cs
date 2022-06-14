using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Individual : TaxPayer
    {
        public double HelthExpenditures { get; set; }

        public Individual(string name, double anualIncoming, double helthExpenditures):base(name,anualIncoming)
        {
            HelthExpenditures = helthExpenditures;
        }
        public override double AnualTaxes()
        {
            if(AnualIncoming > 20000.0)
            {
                return (AnualIncoming * 0.25) - (HelthExpenditures * 0.5);
            }
            else
            {
                return (AnualIncoming * 0.15) - (HelthExpenditures * 0.5);
            }
        }
    }
}
