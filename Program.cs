﻿using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
            List<string> planetList = new List<string> () { "Mercury", "Mars" };

            //1.Add() Jupiter and Saturn at the end of the list.
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            //2.Create another List that contains that last two planet of our solar system.
            List<string> planetListTwo = new List<string> () { "Uranus", "Neptune" };

           //3.Combine the two lists by using AddRange()
            planetList.AddRange (planetListTwo);

            //4.Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert (2, "Earth");
            planetList.Insert (1, "Venus");

            //5.Use Add() again to add Pluto to the end of the list.
             planetList.Add ("Pluto");

             //6.Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.

               string[] rockeyPlanets = planetList.GetRange(0, 4).ToArray();
        
                Console.WriteLine("rockey Planets");
                Console.WriteLine("--------------------------------------------------------");
                foreach( string planet in rockeyPlanets)
                {
                    Console.WriteLine(planet);
                }

             //7.Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
             planetList.Remove ("Pluto");
             Console.WriteLine("More Planets");
            Console.WriteLine ("------------------------------------------------------------");
            foreach (string planet in planetList) {
                Console.WriteLine (planet);

        }
    }
}}