using System;

public class LinkedList
{
    Node head; // head of list

    /* Linked list Node. This inner class is made static so that
    main() can access it */
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        } // Constructor
    }

    /* method to create a simple linked list with 3 nodes*/
    public LinkedList()
    {

        head = new Node(1);
        Node second = new Node(2);
        Node third = new Node(3);

        /* Three nodes have been allocated dynamically.
        We have references to these three blocks as head,
        second and third
 
        llist.head     second             third
            |             |                 |
            |             |                 |
        +----+------+     +----+------+     +----+------+
        | 1 | null |     | 2 | null |     | 3 | null |
        +----+------+     +----+------+     +----+------+ */

        head.next = second; // Link first node with the second node

        /* Now next of first Node refers to second. So they
            both are linked.
 
        llist.head     second             third
            |             |                 |
            |             |                 |
        +----+------+     +----+------+     +----+------+
        | 1 | o-------->| 2 | null |     | 3 | null |
        +----+------+     +----+------+     +----+------+ */

        second.next = third; // Link second node with the third node

        /* Now next of the second Node refers to third. So all three
            nodes are linked.
 
        llist.head     second             third
            |             |                 |
            |             |                 |
        +----+------+     +----+------+     +----+------+
        | 1 | o-------->| 2 | o-------->| 3 | null |
        +----+------+     +----+------+     +----+------+ */
    }

    public void printList()
    {
        int i = 1;
        LinkedList.Node nowNode = head;

        while (i == 1)
        {
            if (nowNode != null)
            {
                System.Diagnostics.Debug.WriteLine(nowNode.data);
                nowNode = nowNode.next;
            }
            else
                break;
        }
    }

    public void ReplaceTheHeadNode(int newNodeData)
    {
        LinkedList.Node newNode = new LinkedList.Node(newNodeData);
        newNode.next = head;
        head = newNode;
    }


    public void InsertAfter(int prevNodeData, int newNodeData)
    {
        Node prevNode = SearchNode(prevNodeData);

        if (prevNode != null)
        {
            Node newNode = new Node(newNodeData);

            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }
        else
            System.Diagnostics.Debug.WriteLine("Please Check the prevNode is exist or not");
    }
    public Node SearchNode(int searchNodeData)
    {

        Node nowNode = head;

        while (nowNode != null)
        {
            if (nowNode.data == searchNodeData)
                break;
            else
                nowNode = nowNode.next;
        }

        return nowNode;
    }

    public void SearchNodeByPosition(int position)
    {
        int pos = 0;
        Node nowNode = head;

        while (nowNode != null)
        {
            if (pos == position)
            {
                System.Diagnostics.Debug.WriteLine("Search Position Data is " + nowNode.data);
                break;
            }
            else
            {
                nowNode = nowNode.next;
                pos++;
            }

        }
    }
    public void DeleteNode(int deleteNodeData)
    {
        Node nowNode = head;
        Node prevNode = null;

        if (nowNode != null && nowNode.data == deleteNodeData)
        {
            head = nowNode.next;
            return;
        }

        while (true)
        {
            if (nowNode != null)
            {
                if (nowNode.data == deleteNodeData)
                {
                    prevNode.next = nowNode.next;
                    nowNode.next = null;
                    break;
                }
                else
                {
                    prevNode = nowNode;
                    nowNode = nowNode.next;
                }
            }
            else
                break;
        }
    }

    public void DeleteGivenPositionNode(int deletePosition)
    {
        Node nowNode = head;
        Node prevNode = null;
        int pos = 1;

        if (nowNode != null && pos == deletePosition)
        {
            head = nowNode.next;
            return;
        }

        while (nowNode != null)
        {
            if (pos == deletePosition)
            {
                prevNode.next = nowNode.next;
                nowNode.next = null;
                break;
            }
            else
            {
                prevNode = nowNode;
                nowNode = nowNode.next;
                pos++;
            }
        }
    }

    public void GetLinkedListLength()
    {
        int length = 1;
        Node nowNode = head;


        if (nowNode != null)
        {
            while (nowNode.next != null)
            {
                nowNode = nowNode.next;
                length++;
            }
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("List is Empty");
            length = 0;

        }

        System.Diagnostics.Debug.WriteLine("LinkedList Length Is " + length);

    }



}