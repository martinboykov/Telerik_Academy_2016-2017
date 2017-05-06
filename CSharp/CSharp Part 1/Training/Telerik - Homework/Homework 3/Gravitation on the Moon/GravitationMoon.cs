//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
//Examples:

//weight    weight on the Moon
//86	    14.62
//74.6	    12.682
//53.7	    9.129

using System;

class GravitationMoon
{
    static void Main()
    {
        decimal weightOne = 86m;
        decimal weightTwo = 74.6m;
        decimal weightThree = 53.7m;
        decimal weightMoonOne = weightOne * 0.17m;
        decimal weightMoonTwo = weightTwo * 0.17m;
        decimal weightMoonThree = weightThree * 0.17m;

        Console.WriteLine(weightOne + " weight on Earth corresponds to " + weightMoonOne + " weight on the Moon.");
        Console.WriteLine(weightTwo + " weight on Earth corresponds to " + weightMoonTwo + " weight on the Moon.");
        Console.WriteLine(weightThree + " weight on Earth corresponds to " + weightMoonThree + " weight on the Moon.");

        //output:
        //86 weight on Earth corresponds to 14.62 weight on the Moon
        //74.6 weight on Earth corresponds to 12.682 weight on the Moon
        //53.7 weight on Earth corresponds to 9.129 weight on the Moon
    }
}