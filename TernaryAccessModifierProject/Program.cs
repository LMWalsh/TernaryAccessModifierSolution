﻿using System;

namespace TernaryAccessModifierProject {
    public class Program {
        static void Main(string[] args) {

            var nextID = Customer.ne
            Console.WriteLine($"The cube of 17 is {Program.Cubed(17)}");
            var message = Customer.PrintNextId();
            Console.WriteLine(message);    
                
            var cust1 = new Customer ("Max Technical Training");
            var cust2 = new Customer("Amazon");
            var cust3 = new Customer("Target");
            cust1.NationalAccount("yes");

            var order1 = new Order { Id = 1, Amount = 1000, Customer = cust1 };

        }
        static int Cubed(int nbr) {
            return nbr * nbr * nbr;
        }
    }
}
