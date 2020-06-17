using System;

namespace Tables2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Tables[] tables = new Tables[10];
            Random random = new Random();
       
            for ( i = 0; i < 10; i++)
            {
                tables[i] = new Tables(random.Next(50, 201), random.Next(50, 201));
                tables[i].ShowData();
            }
            CoffeeTable coffeeTable = new CoffeeTable();
            coffeeTable.Display();
            CoffeeTable[] coffeeTables= new CoffeeTable[5];
         
            for ( i = 0; i < 10; i++)
            {
             coffeeTables[i] = new CoffeeTable(random.Next(40, 120), random.Next(40, 120));
              
            }
              coffeeTables[i].ShowData();

        }
    }
}
