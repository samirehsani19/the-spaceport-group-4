﻿using System;
using System.Collections.Generic;
using RestSharp;
using RestSharp.Authenticators;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
namespace SpacePort
{
    class Program
    {
        static void Main(string[] args)
        {
            //pass these values.  #string name, string shipN, DateTime arrTime, DateTime dpTime, int price
            //Spaceport s = new Spaceport();

            //s.InsertDataToTciketDB("Samir", "Star Fighter", Convert.ToDateTime("2020-03-26 12:30:00"), Convert.ToDateTime("2020-03-27 14:30:00"), 500);
            //Console.WriteLine("Data Found In Database");  //comment out this code together with display receipt
            //s.DisplayReceipt("Samir"); // shows receipt by person name
            //s.RemovePerson("Mikee");  // remove someone from database
            //Console.ReadKey();

            Menu.Display();
        }
    }
}
