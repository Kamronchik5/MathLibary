﻿using System.Diagnostics.CodeAnalysis;

namespace MathLibary
{
    internal class MathLib
    {
        public int[] Fibonaci(int n)
        {
            int[] arr = new int[n];
            arr[0] = 0;
            arr[1] = 1;
            
            for(int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i-2];
            }
            return arr;
        }
        public bool Tub(int n) 
        {
            for (int i = 2; i * i <= n;i++)
                if(n%i == 0) return false;
            return true;
        }
        public double a { get; set; }
        public double b { get; set; }
        public double p { get; set; }
        public bool Pifagor()
        {
            double r;
            r =(a * a + b * b);
            if (p * p == r) return true;
            return false;
        }
        
    }
}
