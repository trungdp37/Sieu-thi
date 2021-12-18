
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections;
using System;
using St;
using DT;
namespace BT
{

    class Program
    {
        static void Hienthongtin(Sieuthi a)
        {
            Console.WriteLine("Ma ID: {0}", a.getid());
            Console.WriteLine("Ten sieu thi: {0}", a.gettensieuthi());
            Console.WriteLine("Giam doc: {0}", a.getgiamdoc());
            Console.WriteLine("Dia chi: {0}", a.getdiachi());
            Console.WriteLine("SDT lien he: {0}", a.getsdt());
        }
        static void Main(string[] args)
        {
            Sieuthi a = new Sieuthi("001", "CoopMart", "Nguyen Van A", "Ha Noi", "0123456789");
            Sieuthi b = new Sieuthi("002", "Thanh Nghia", "Tran Van B", "Da Nang", "0123456788");
            Sieuthi c = new Sieuthi("003", "Big C", "Le Van C", "Quang Ngai", "0123456787");
            Sieuthi d = new Sieuthi("004", "Lotte Mark", "Nguyen Thi D", "Tp.HCM", "0123456786");
            Console.WriteLine("1. Hien thong tin sieu thi.");
            Console.WriteLine("2. Hien duong di ngan nhat");
            int biendem = 1;
            while (biendem == 1)
            {
                Console.Write("Chon chuc nang: ");
                int temp = int.Parse(Console.ReadLine());
                if (temp == 1)
                {
                    Console.Write("Nhap sieu thi can hien thong tin (a, b, c, d): ");
                    string name = Console.ReadLine();
                    if (name == "a") Hienthongtin(a);
                    else if (name == "b") Hienthongtin(b);
                    else if (name == "c") Hienthongtin(c);
                    else if (name == "d") Hienthongtin(d);
                    else Console.WriteLine("Khong hop le!");
                }
                else if (temp == 2)
                {
                    Graph thegraph = new Graph();
                    thegraph.AddVertex(a.getdiachi());
                    thegraph.AddVertex(b.getdiachi());
                    thegraph.AddVertex(c.getdiachi());
                    thegraph.AddVertex(d.getdiachi());
                    thegraph.AddEdge(0, 3, 2000);
                    thegraph.AddEdge(0, 1, 900);
                    thegraph.AddEdge(1, 2, 120);
                    thegraph.AddEdge(2, 3, 900);
                    Console.WriteLine("Khoang cach ngan nhat: ");
                    thegraph.Path();
                    Console.WriteLine("");
                }
                else Console.WriteLine("Khong hop le!");
            }
        }
    }
}