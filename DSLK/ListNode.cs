using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK
{
    internal class ListNode
    {
        public Node pHead;
        public Node pTail;
        public Node node; 
        public ListNode()
        {
            pHead = pTail = null;
            node = new Node();

        }

        public void addNode(Node node)
        {
            if(pHead == null)
            {
                pHead = pTail = node;
            }
            else
            {
                pTail.pNext = node;
                pTail = node;
            }
        }

        public void InputList(int x)
        {
            for(int i = 0; i < x; i++)
            {
                Node p = new Node();
                p.Input();
                addNode(p);
            }
        }

        public void OutputList()
        {
            for (Node i = pHead; i != null; i= i.pNext)
            {
                
                i.Output();
            }
        }



    }
}
