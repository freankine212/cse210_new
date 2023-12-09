using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("1234 State Street", "Cawlson", "Tx", "USA");

        Lecture lecture = new Lecture("How to rock out and rock out well'", "Metal expose with legendary Rocker Dredd Johnson", "January 4, 2024", "3 PM", address, "Dredd Johnson", "Forty-five");
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("Caldwell Park Building", "Pocatello", "Idaho", "USA");

        Reception reception = new Reception("Jack and Mary's Wedding Reception", "First time, hopefully the last time", "April 30 2025", "12 PM", addressR, "Jack and Mary Wedding");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("123 Farm Road", "Aberdeen", "Idaho", "USA");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Hunter's Ed field Day", "Hunters Education Field Day where to put into practice what you learned", "August 5, 2024", "8 AM", addressOG, "partly cloudy");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}