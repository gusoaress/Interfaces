using System;
using System.Globalization;
using Rental.Entities;
using Rental.Services;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data"); 
        Console.Write("Car model: ");
        string model = Console.ReadLine(); 
        Console.Write("Pick up date and time (dd/MM/yyyy HH:mm): ");
        DateTime pickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); 
        Console.Write("Return date and time (dd/MM/yyyy HH:mm): ");
        DateTime returndate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); 

        Console.Write("Enter price per hour: ");
        double hour = double.Parse(Console.ReadLine()); 
        Console.Write("Enter price per day: ");
        double day = double.Parse(Console.ReadLine());
        
        
        CarRental carRental = new CarRental (pickup, returndate, new Vehicle (model));
        RentalService rentalService = new RentalService(hour, day);

        
        rentalService.ProcessInvoice(carRental);

        
        Console.WriteLine($"Invoice: {carRental.Invoice}"); 


        
    }
}         