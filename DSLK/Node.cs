using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK
{
    internal class Node
    {
        public Node pNext;
        public int data;
        public string name;
        public string country;
        public string family;
        public Node(int data, string name , string country , string family)
        {
            this.data = data;
            this.name = name;
            this.country = country;
            this.family = family;
            pNext = null;
        }
        public Node()
        {

        }

        public void Input()
        {
            Console.Write("ID : ");
            data = int.Parse(Console.ReadLine());
            Console.Write("Name : ");
            name = Console.ReadLine();
            Console.Write("Country : ");
            country = Console.ReadLine();
            Console.Write("Family : ");
            family = Console.ReadLine();
            pNext = null; 
            
        }

        public void Output()
        {

            Console.WriteLine($"ID : {data}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Country : {country}");
            Console.WriteLine($"Family : {family}");
            Console.WriteLine("---------------------");
        }
    }
}
