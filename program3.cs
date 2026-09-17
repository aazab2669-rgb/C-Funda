namespace InventorySystem
{
    internal class Program
    {
            static string[,] inventory = new string[numberofproduct,3];
            const int numberofproduct = 50;
            static int productCount = 0;            

        static void Main(string[] args)
        {
            //Add product
            //Update product
            //View product(ID,Name,Quantity,Price)
            //Exit
            while (true)
            {
            Console.WriteLine("Welcome to inventory system, Enter your choice");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Update product");
            Console.WriteLine("3. View product");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                //Add product
                    AddProduct();
                    break;
                case 2:
                //Update product
                  Updateproduct();
                    break;
                case 3:
                //View product
                    ViewProduct();
                    break;
                case 4:
                //Exit
                    Environment.Exit(0);
                    break;  
                
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            }
            
        }
        private static void AddProduct()
        {
            
            Console.WriteLine("Enter product Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter product quntity:");
            string quntity =  Console.ReadLine();

            Console.WriteLine("Enter product Price:");
            string Price = Console.ReadLine();

            inventory[productCount,0] = name;
            inventory[productCount,1] = quntity;
            inventory[productCount,2] = Price;
            ++productCount;
            Console.WriteLine(" product Added Succesfully:");
        }
        private static void ViewProduct()
        {
            if (productCount>0)
            {
                Console.WriteLine("Products List :");

                for (int i = 0; i < productCount; i++)
                {
                    Console.WriteLine($"Product ID :{i} // Product Name :{inventory[i,0]} // Product Quantity :{inventory[i,1]} // Product Price :{inventory[i,2]}");
                }
            }
            else
            {
                Console.WriteLine("No Products Avalible");
            }
            
        }
        private static void Updateproduct()
        {
            Console.WriteLine("Enter product Name to update:");
            string searchproduct = Console.ReadLine();
            int productID = -1;
            if (productCount > 0)
            {
              for (int i = 0; i < productCount; i++)
              {
                 
                if (inventory[i,0]== searchproduct)
                {
                   productID = i;
                   break;

                }
              }  
              if (productID != -1)
                {
                    Console.WriteLine("Enter New quantity:");
                    string newquantity = Console.ReadLine();
                    inventory[productID,1] = newquantity;
                    Console.WriteLine("quantity updated successfully:");
                }
            }
            else
            {
                Console.WriteLine("No Products Avalible");
            }
        }
    }
}
