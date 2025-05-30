﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practricee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> n = new List<int>();

            for (int i = 1; i < 10; i++)
            {
                n.Add(i);
            }

            var query = from num in n
                        where num > 2
                        select num;

            foreach (var n1 in query)
            {
                Console.WriteLine("Query for >2: " + n1);
            }
            string[] names = { "Ali", "Ahmed", "Sara", "Aisha" };
            var query1 = from name in names
                         where name.Length > 3
                         select name;
            foreach (var name in query1)
            {
                Console.WriteLine("Query1: " + name);
            }
            var query2 = from name in names
                         where name.StartsWith("A")
                         select name;
            foreach (var name in query2)
            {
                Console.WriteLine("Query2: " + name);
            }

        }
    }
}