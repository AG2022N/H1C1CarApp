using H1U1BilVærksted;
using System;

while (true)
{
    Console.Clear();
    DateTime CurrentDate = DateTime.Today;

    Console.SetCursorPosition(4, 1);
    Console.Write("Indtast Mærke: ");

    Console.SetCursorPosition(4, 2);
    Console.Write("Indtast Model: ");

    Console.SetCursorPosition(4, 3);
    Console.Write("Indtast Produktionsdato, for eksempel. 2023.4.21: ");
    //DateTime ProductionDate = DateTime.Parse(Console.ReadLine());   - send into object

    Console.SetCursorPosition(4, 4);
    Console.Write("Indtast Dato for sidste syn, for eksempel. 2023.4.21: ");
    //DateTime LastThing = DateTime.Parse(Console.ReadLine());

    //System.TimeSpan Difference = CurrentDate.Subtract(ManufactureDate);

    Console.SetCursorPosition(4, 10);
    string Temp = " ";
    DateTime CurrentTime = DateTime.Now;
    Console.Write("==============================================\n" +
                  $"    Tjekkede: {CurrentTime}\n" +
                  $"    Model: {Temp}\n" +
                  $"    Produktionsdato: {Temp}\n" +
                  $"    Sidst synes: {CurrentTime}\n" +
                  $"    Konklusion: {Temp}");
    Console.ReadKey();
}