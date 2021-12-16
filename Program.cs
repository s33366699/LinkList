using System;

namespace linklist
{
    class Program
    {




        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            llist.ReplaceTheHeadNode(4);
            llist.InsertAfter(2, 5);
            llist.InsertAfter(3, 7);
            llist.DeleteNode(4);
            llist.DeleteGivenPositionNode(6);
            llist.GetLinkedListLength();
            llist.SearchNodeByPosition(2);
            llist.printList();
        }

    }
}
