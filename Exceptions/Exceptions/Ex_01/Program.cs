using System;
using System.Xml;
using Ex_01.Entities;
using Ex_01.Entities.Exceptions;


namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Enter the number of Reservation");
                int n = int.Parse(Console.ReadLine());

                List<Reservation> list = new List<Reservation>();

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Reservation #{i}:");
                    Console.Write("Room number: ");
                    int roomNumber = int.Parse(Console.ReadLine());
                    Console.Write("Check-in date (dd/MM/yyyy): ");
                    DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    Console.Write("Check-out date (dd/MM/yyyy): ");
                    DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                    Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                    list.Add(reservation);
                    Console.WriteLine(reservation);

                }

                Console.WriteLine("All reservations");
                foreach (Reservation reservation in list)
                {
                    Console.WriteLine(reservation);
                }

                Console.WriteLine("Do you want modify a reservation ? (s/n)");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 's')
                {
                    Console.Write("Enter the number of Reservation to update: ");
                    int r = int.Parse(Console.ReadLine());
                    int index = list.FindIndex(x => x.RoomNumber == r);

                    if (index != -1)
                    {
                        Console.Write("Enter the new Check-in date (dd/MM/yyyy): ");
                        DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.Write("Enter the new Check-out date (dd/MM/yyyy): ");
                        DateTime checkout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        list[index].UpdateDates(checkIn, checkout);
                    }
                    else
                    {
                        Console.WriteLine("This reservation does not exist");
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);

            }

        }
    }

}

