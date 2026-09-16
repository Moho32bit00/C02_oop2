namespace oop02_assi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 01 : Theoretical Questions
            //Question 1
            //a) class support inhertance while struct doesn't
            //b) because class do support all oop pillars and more suitable for complex data and operations


            //Question 2
            //a) Shipment  .
            //b) ExpressShipment  .
            //c) " Tracking Code " .
            //d) because it's better for the readability and reusability .


            // Part 02 : Practical - in main 
            DeliveryCenter d = new DeliveryCenter();
            Console.Write("enter the Delivery Center name : ");
            string CenterName = Console.ReadLine();
            d.CenterName = CenterName;

            StandardShipment s = new StandardShipment();
            ExpressShipment e = new ExpressShipment();
            InternationalShipment i = new InternationalShipment();

            int Counter = 0;

            while (Counter < 3)
            {
                Console.WriteLine("Enter Shipment data : ");

                Console.Write("City : ");
                string city = Console.ReadLine();

                Console.Write("street : ");
                string street = Console.ReadLine();

                Console.Write("Building number : ");
                int B_N = Convert.ToInt32(Console.ReadLine());

                Console.Write("Description : ");
                string description = Console.ReadLine();

                Console.Write("Weight : ");
                decimal Weight = Convert.ToDecimal(Console.ReadLine());

                Counter++;
                string code = Counter.ToString();
                Shipment s1 = new Shipment(code);
                s1.Weight = Weight;
                s1.Description = description;
                s1.Destination = new DeliveryAddress(city, street, B_N); ;
                d.AddShipment(s1);
            }

            Console.WriteLine("All Shipments : \n");
            d.PrinAllShipment();

            Console.WriteLine("Enter the tracking code : ");
            string tc = Console.ReadLine();
            d[tc].PrintShipment();
            Console.WriteLine();

            Console.WriteLine("Enter the tracking code to remove a Shipment : ");
            tc = Console.ReadLine();
            d.RemoveShipment(tc);

            d.PrinAllShipment();
        }
    }
}
