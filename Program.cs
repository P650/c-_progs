using System;
    
namespace Restaurent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Restaurents myres = new Restaurents("Kadamba", "123 main", 56.556);
            myres.GenerateReceipt();
        }
    }

    public class Restaurents
    {
        private string name;
        private string address;
        private double gratuityRate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private double GratuityRate
        {
            get { return gratuityRate; }
            set
            {
                if (value > 0)
                {
                    gratuityRate = value;
                }
            }
        }

        // constructor

        public Restaurents(string name, string address, double gratuityRate)
        {
            this.name = Name;
            this.address = Address;
            this.gratuityRate = GratuityRate;
        }

        public void GenerateReceipt()
        {
            double price = 0;
            double subtotal = 0;
            double grandtotal = 0;
            double gratuityamount = 0;
            int people = 0;

            while(price != -1)
            {
                subtotal = subtotal + price;
                Console.Write("Enter price of the food item [-1 to quit]: ");
                price = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("How many people are in the party: ");
            people = Convert.ToInt32(Console.ReadLine());

            if (people >= 6)
            {
                gratuityamount = subtotal * gratuityRate;
            }

            grandtotal = subtotal * gratuityamount;

            Console.WriteLine("Subtotal: {0} ", subtotal);
            Console.WriteLine("{0} Gratuity rate and amount: {1}", gratuityRate, gratuityamount);
            Console.WriteLine("Grand total: {0}", grandtotal);
        }
    }

}