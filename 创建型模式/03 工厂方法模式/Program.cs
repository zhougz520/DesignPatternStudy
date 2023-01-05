﻿using FactoryMethod.Factorys;
using FactoryMethod.Operations;

class Program
{
    static void Main(string[] args)
    {
        IFactory operFactory = new AddFactory();
        Operation oper = operFactory.CreateOperation();
        oper.NumberA = 1;
        oper.NumberB = 2;
        double result = oper.GetResult();

        Console.WriteLine(result);
    }
}