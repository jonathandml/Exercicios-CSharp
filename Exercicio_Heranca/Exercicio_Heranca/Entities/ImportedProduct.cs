using System.Globalization;

namespace Exercicio_Heranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name,price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {  
            return Name + " $ " + (Price + CustomsFee).ToString("F2", CultureInfo.InvariantCulture) + " (Customs Fee: $ " + CustomsFee +")";
        }
    }
}
