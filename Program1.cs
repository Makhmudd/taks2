﻿using System;  namespace Makhmud {     class MainClass     {          static bool Makha(int n)         {             for (int i = 2; i <= Math.Sqrt(n); i++)             {                 if (n % i == 0) return false;             }             return true;         }            public static void Main(string[] args)         {               for (int i = 0; i < args.Length; i++)             {                 if (Makha(int.Parse(args[i])))                     Console.WriteLine(args[i]);             }              Console.ReadKey();         }     } }  