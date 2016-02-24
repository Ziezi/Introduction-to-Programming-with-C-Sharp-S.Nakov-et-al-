﻿///<summary> 
///TITLE              Moon's Gravity  Chapter3Exercise7.cs 
///    COMMENT
///        Objective: Write an expression that calculates
///                   the weight of an object on the Moon,
///                   given that its gravity is 16.6% of
///                   Earth's.
///            Input: -
///           Output: Object with mass of: 10[kg] will weigh: 16.26[N] on the Moon.
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>23.02.2016</datecreated>

using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise7
    {
        static void Main()
        {
            Console.WriteLine("Type a mass in [kg]:");
            double massOfObject = Convert.ToDouble(Console.ReadLine()); // kg
            double earthGravitationalStregth = 9.8f;                    // N / m^2 or N / kg

            double moonGravitationalStrength = earthGravitationalStregth * (16.6f / 100.0f); // N / kg
            double weightOfObjectOnMoon = moonGravitationalStrength * massOfObject;          // N

            string printResult = "Object with mass of: " + massOfObject + "[kg] will weigh: " 
                                                         + weightOfObjectOnMoon + "[N] on the Moon.";
            Console.WriteLine(printResult);
        }
    }
}
