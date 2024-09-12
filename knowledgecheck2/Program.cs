// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using knowledgecheck2;
using System;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<MagicSet>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myClass = new MagicSet();

    Console.WriteLine("Enter the value for Set Name");
    myClass.SetName = Console.ReadLine();

    Console.WriteLine("Enter the value for Set Year");
    myClass.SetYear = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the value for Card Name");
    myClass.CardName = Console.ReadLine();

    Console.WriteLine("Enter the value for Card Rarity");
    myClass.CardRarity = Console.ReadLine();

    recordList.Add(myClass);

}

foreach(var record in recordList)
    {
    Console.WriteLine($"Card Name = {record.CardName}, Card Rarity = {record.CardRarity}, Set Name = {record.SetName}, Set Year = {record.SetYear.ToString()}");
}