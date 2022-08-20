using CodingTest;

class Program
{
    public static Customer customer = new Customer();
    public static VendingMachine vendingMachine = new VendingMachine();
    static void Main(string[] args)
    {
        Console.WriteLine("Press '1' for Cola, '2' for Chips and '3' for Candy");
        char productType = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch(productType)
        {
            case '1':
                Console.WriteLine("you have selected Cola please insert a coin of value $1.0");
                start1:
                vendingMachine.InsertCoin(Convert.ToDecimal(Console.ReadLine()));
                if (vendingMachine.InsertedCoin >= 1M)
                {
                    vendingMachine.DispenseProduct(productType);
                    Console.WriteLine("THANK YOU");
                }
                else
                { 
                    Console.WriteLine("Please insert a coin");
                    goto start1;
                }
                customer.customerProductList.Add(Products.Cola);
                customer.Money += Products.Cola.Price;
                break;
            case '2':
                Console.WriteLine("you have selected Chips please insert a coin of value $0.5");
                start2:
                vendingMachine.InsertCoin(Convert.ToDecimal(Console.ReadLine()));
                if (vendingMachine.InsertedCoin >= 0.5M)
                {
                    vendingMachine.DispenseProduct(productType);
                    Console.WriteLine("THANK YOU");
                }
                else
                {
                    Console.WriteLine("Please insert a coin");
                    goto start2;
                }
                customer.customerProductList.Add(Products.Chips);
                customer.Money += Products.Chips.Price;
                break;
            case '3':
                Console.WriteLine("you have selected Candy please insert a coin of value $0.65");
                start3:
                vendingMachine.InsertCoin(Convert.ToDecimal(Console.ReadLine()));
                if (vendingMachine.InsertedCoin >= 0.65M)
                {
                    vendingMachine.DispenseProduct(productType);
                    Console.WriteLine("THANK YOU");
                }
                else
                {
                    Console.WriteLine("Please insert a coin");
                    goto start3;
                }
                customer.customerProductList.Add(Products.Candy);
                customer.Money += Products.Candy.Price;
                break;

        }
    }


}