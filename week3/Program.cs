﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            BAStudent y = new BAStudent(true);
            y.Grade = 100;
            MAStudent z = new MAStudent(false); 
            
            Console.WriteLine(y);

            List<Student> StudentsList = new List<Student>();

            StudentsList.Add(y);
            StudentsList.Add(z);
            int i = 0;
            if (StudentsList[i] is BAStudent )
            {
                ((BAStudent)StudentsList[i]).Milga = true; // casting 
                Console.WriteLine ((StudentsList.First() as BAStudent).Milga);
            }
            foreach (Student s in StudentsList)
            {
                if (s is BAStudent)
                {
                    Console.WriteLine((s as BAStudent).Milga);
                }
            }
            StudentsList.Sort();
            
            string str = Console.ReadLine();
            int[] arr = TestStringSplit.ToIntArray(str);  
            
        }
    }
}
