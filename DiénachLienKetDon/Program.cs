using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiénachLienKetDon
{ 
    class Node
    {
        private int info;
        private Node next; 
        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int Info
        {
            set { this.info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { this.next = value; }
            get { return next; }
        }
    }
    class SingleLinkList
    {
        private Node Head;
        public SingleLinkList()
        {
            Head = null;
        }
        public void AddHead (int x)
        {
            Node p = new Node(x);
            p.Next = Head;
            Head = p;
        }
        public void AddLast(int x)
        {
            Node p = new Node(x);
            if (Head == null)
            {
                Head = p;
            }
            else
            {
                Node q = Head;
                while(q.Next!= null)
                {
                    q = q.Next;
                }
                q.Next = p;
            }
        }
        public void Deletehead()
        {
            if (Head != null)
            {
                Node p = Head;
                Head = Head.Next;
                p.Next = null;
            }
        }
         public void DeleteLast()
        {
            if (Head != null)
            {
                Node p = Head;

                Node q = null;
                while (p.Next != null)
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = null;
            }
        }

        public void processList()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write($"{p.Info} ");
                p = p.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList A = new SingleLinkList();
            Console.WriteLine("Dan sach lien ket la: ");
            A.AddHead(4);
            A.AddHead(6);
            A.AddHead(2);
            A.AddHead(12);
            A.processList();

            A.Deletehead();
            Console.WriteLine("\nDanh sach lien ket sau khi xoa nut dau: ");
            A.processList();
            A.DeleteLast();
            Console.WriteLine("\nDanh sach lien ket sau khi xoa nut cuoi: ");
            A.processList();
            Console.ReadKey();
        }
    }
}
