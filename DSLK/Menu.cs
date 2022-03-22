using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK
{
    internal class Menu
    {
        public Node node;
        public ListNode list;
        public int lc; 
        public Menu()
        {
            node = new Node();
            list = new ListNode();
            lc = 0;
        }

        public void hienthi()
        {
            Console.WriteLine("0. OUT  ");
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
        }
        public void Option()
        {
            Console.Write("Nhap lua chon cua ban :  ");
            lc = int.Parse(Console.ReadLine());
        }

        public void start()
        {
            do
            {
                hienthi();
                Option();
                switch(lc)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                }

            } while (lc != 0);
        }


    }
}
