﻿//Gunawan Dwi Wicaksono, NRP: 5220600049 
using System;
using System.Text.Json; //to include serialize and unserialize
using System.IO; //contain standard type input output command such as classes, structures, etc

namespace Arsijar2
{
    // variable class
    class account
    {
        public string name { get; set; }
        public string password { get; set; }
    }
    //main class
    class menu
    {
        static void Main()
        {
            //create new
            account user = new account();
            //input
            Console.WriteLine("Username : "); user.name = Console.ReadLine();
            Console.WriteLine("Password : "); user.password = Console.ReadLine();
            //create file
            string filename = "account.json";
            //convert to json
            string jsonstring = JsonSerializer.Serialize(user);
            File.WriteAllText(filename, jsonstring);
            Console.WriteLine(File.ReadAllText(filename));
            //open json as text
            account account = JsonSerializer.Deserialize<account>(jsonstring)!;

            Console.WriteLine($"Username : {user.name}");
            Console.WriteLine($"Password : {user.password}");

        }
    }
}