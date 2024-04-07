using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_9_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HotelManager Manager = new HotelManager();

            Manager.AddHotel(new Hotel("Hotel A", "Address A", 4, 8.5));
            Manager.AddHotel(new Hotel("Hotel B", "Address B", 3, 7.2));
            Manager.AddHotel(new Hotel("Hotel C", "Address C", 5, 9.3));
            Manager.ShowHotel();
            Manager.RemoveHotel("Hotel B");
            Manager.ShowHotel();

            Hotel HighestRatedHotel = Manager.GetHotelHighRate();
            Console.WriteLine($"Готелі з найбільшим рейтенгом: {HighestRatedHotel.Name}, Рейтинг: {HighestRatedHotel.Rate}");

    
            List<Hotel> HighRatedHotels = Manager.GetHotelsWithRating(9.0);
            Console.WriteLine("Готелі з рейтенгом 9.0 і вище:");
            foreach (var hotel in HighRatedHotels)
            {
                Console.WriteLine($"Назва: {hotel.Name} Рейтенг: {hotel.Rate}");
            }
            Console.ReadLine();

            /*Список готелів
            Назва: Hotel A Адреса: Address A Рейтинг: 8,5 Зірки: 4
            Назва: Hotel B Адреса: Address B Рейтинг: 7,2 Зірки: 3
            Назва: Hotel C Адреса: Address C Рейтинг: 9,3 Зірки: 5
            Список готелів
            Назва: Hotel A Адреса: Address A Рейтинг: 8,5 Зірки: 4
            Назва: Hotel C Адреса: Address C Рейтинг: 9,3 Зірки: 5
            Готелі з найбільшим рейтенгом: Hotel C, Рейтинг: 9,3
            Готелі з рейтенгом 9.0 і вище:
            Назва: Hotel C Рейтенг: 9,3*/
        }
    }
}
