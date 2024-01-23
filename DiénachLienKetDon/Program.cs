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
        public void Delete(int x)
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null;

                while (p!=null&& p.Info != x)
                {
                    q = p;
                    p = p.Next;
                }
                if (p == Head)
                {
                    Deletehead();
                }
                else
                {
                    q.Next = p.Next;
                    p.Next = null; 
                }
            }
        }
        public Node findMax()
        {
            Node max = Head;
            Node p = Head.Next;
            while (p != null)
            {
                if (p.Info > max.Info)
                {
                    max = p;
                }
                p = p.Next;
            }
            return max;
        }
        public float Avg()
        {
            float sum = 0;
            int count = 0;
            Node p = Head;
            while (p != null)
            {
                sum += p.Info;
                count++;
                p = p.Next;
            }
            return sum / count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList A = new SingleLinkList();
            NhapDanhSach(A);
            Console.WriteLine("Dan sach lien ket la: ");

            A.AddHead(4);
            A.AddHead(6);
            A.AddHead(2);
            A.AddHead(12);
            A.processList();
            int x;
            A.Deletehead();
            Console.WriteLine("\nDanh sach lien ket sau khi xoa nut dau: ");
            A.processList();
            A.DeleteLast();
            Console.WriteLine("\nDanh sach lien ket sau khi xoa nut cuoi: ");
            A.processList();
            Console.WriteLine("\nXoa vi tri x: ");
            x = int.Parse(Console.ReadLine());
            A.Delete(x);
            Console.WriteLine("Danh sach sau khi xoa:");
            A.processList();

            Node max = A.findMax();
            Console.WriteLine($"\nNut co gia tri lon nhat: {max.Info}");

            float tbc = A.Avg();
            Console.WriteLine($"\nGia tri trung binh cac nut: {tbc}");
            Console.ReadKey();
        }
        static void NhapDanhSach(SingleLinkList A)
        {
            string chon = "y";
            int x;
            while (chon != "n")
            {
                Console.Write("Nhap gia tri nut n:");
                x = int.Parse(Console.ReadLine());
                A.AddHead(x);
                Console.Write("Continue (y/n)?");
                chon = Console.ReadLine();
            }
        }
    }
}
