using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_9_Hotel
{
    internal class Hotel
    {
        public string Name;
        public string Adrress;
        public double Stars;
        public double Rate;


        public Hotel(string name, string adrress, double stars, double rate)
        {
            Name = name;
            Adrress = adrress;
            Stars = stars;
            Rate = rate;
        }
    }
    class HotelManager { 

        public List<Hotel> hotels;

        public HotelManager()
        {
            hotels = new List<Hotel>(); 
        }

        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);  
        }
        public void ShowHotel()
        {
            Console.WriteLine("Список готелів");
            foreach (var hotel in hotels)
            {
                Console.WriteLine($"Назва: {hotel.Name} Адреса: {hotel.Adrress} Рейтинг: {hotel.Rate} Зірки: {hotel.Stars}");
            }
        }
            public void RemoveHotel(string name)
            {
                foreach (var hotel in hotels)
                {
                    if (hotel.Name == name)
                    {
                        hotels.Remove(hotel);
                    break;
                    }
                }
                
            }

            public Hotel GetHotelHighRate()
            {
                Hotel HighestRatedHotel = null;
                double MaxRate = 0;

                foreach (var hotel in hotels)
                {
                    if (hotel.Rate > MaxRate)
                    {
                        HighestRatedHotel = hotel;
                        MaxRate = hotel.Rate;
                    }
                }

                return HighestRatedHotel;
            }

            public List<Hotel> GetHotelsWithRating(double MinRate)
            {
                List<Hotel> HighRatedHotels = new List<Hotel>();

                foreach (var hotel in hotels)
                {
                    if (hotel.Rate >= MinRate)
                    {
                        HighRatedHotels.Add(hotel);
                    }
                }

                return HighRatedHotels;
            }
            
        }
     }

   
