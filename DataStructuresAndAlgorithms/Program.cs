﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresAndAlgorithms.LinkedList;
namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedList<int> lnk = new SimpleLinkedList<int>();
            lnk.AddLast(1);
            lnk.AddLast(2);
            lnk.AddLast(3);
            lnk.AddLast(4);
            lnk.AddFirst(0);
            lnk.ReadAll();
        }
    }
}
