﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayOne
{
    internal class Calculator
    {
        public static int Add(int p1,int p2)
        {
            return p1+p2;
        }
        public static int Subtract(int p1,int p2)
        {
            return p1-p2;
        }
        public static int Multiply(int p1,int p2)
        {
            return p2*p1;
        }
        public static int Divide(int p1,int p2)
        {
            return p2/p1;
        }
    }
}
