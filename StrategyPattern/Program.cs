namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hotelList1 = new List<Hotel>()
            {
                new Hotel()
                {
                    City = "M",
                    HotelId = 1,
                    Name = "hotelA",
                    Price = 10,
                    ProviderId = 1,
                },
                new Hotel()
                {
                    City = "A",
                    HotelId = 2,
                    Name = "hotelB",
                    Price = 11,
                    ProviderId = 1,
                },
                new Hotel()
                {
                    City = "B",
                    HotelId = 3,
                    Name = "hotelC",
                    Price = 12,
                    ProviderId = 1,
                },
                new Hotel()
                {
                    City = "C",
                    HotelId = 4,
                    Name = "hotelD",
                    Price = 5,
                    ProviderId = 1,
                }
            };

            var hotelList2 = new List<Hotel>()
            {
                new Hotel()
                {
                    City = "M",
                    HotelId = 1,
                    Name = "hotelB",
                    Price = 13,
                    ProviderId = 2,
                },
                new Hotel()
                {
                    City = "C",
                    HotelId = 2,
                    Name = "hotelC",
                    Price = 15,
                    ProviderId = 2,
                },
                new Hotel()
                {
                    City = "B",
                    HotelId = 3,
                    Name = "hotelD",
                    Price = 3,
                    ProviderId = 2,
                },
                new Hotel()
                {
                    City = "C",
                    HotelId = 4,
                    Name = "hotelE",
                    Price = 78,
                    ProviderId = 2,
                }
            };

            var hotelList3 = new List<Hotel>()
            {
                new Hotel()
                {
                    City = "M",
                    HotelId = 1,
                    Name = "hotelC",
                    Price = 43,
                    ProviderId = 3,
                },
                new Hotel()
                {
                    City = "D",
                    HotelId = 2,
                    Name = "hotelD",
                    Price = 2,
                    ProviderId = 3,
                },
                new Hotel()
                {
                    City = "E",
                    HotelId = 3,
                    Name = "hotelE",
                    Price = 33,
                    ProviderId = 3,
                },
                new Hotel()
                {
                    City = "R",
                    HotelId = 4,
                    Name = "hotelF",
                    Price = 12,
                    ProviderId = 3,
                }
            };

            var hotelList4 = new List<Hotel>()
            {
                new Hotel()
                {
                    City = "R",
                    HotelId = 1,
                    Name = "hotelD",
                    Price = 434,
                    ProviderId = 4,
                },
                new Hotel()
                {
                    City = "T",
                    HotelId = 2,
                    Name = "hotelE",
                    Price = 23,
                    ProviderId = 4,
                },
                new Hotel()
                {
                    City = "W",
                    HotelId = 3,
                    Name = "hotelF",
                    Price = 313,
                    ProviderId = 4,
                },
                new Hotel()
                {
                    City = "Q",
                    HotelId = 4,
                    Name = "hotelG",
                    Price = 132,
                    ProviderId = 4,
                }
            };


            var provider1 = new Provider
            {
                ProviderId = 1,
                Name = "provider1",
                Hotels = hotelList1
            };
            var provider2 = new Provider
            {
                ProviderId =2,
                Name = "provider2",
                Hotels = hotelList2
            };
            var provider3 = new Provider
            {
                ProviderId = 3,
                Name = "provider3",
                Hotels = hotelList3
            };
            var provider4 = new Provider
            {
                ProviderId = 4,
                Name = "provider4",
                Hotels = hotelList4
            };

            var minPolicy = new MinPricePolicy();
            var maxPolicy = new MaxPricePolicy();

            var orderCondition = new OrderCondition()
            {
                ProviderOrders = new List<int> { 4, 3, 2, 1 }
            };

            var orderPolicy = new OrderPolicy()
            {
                Condition = orderCondition,
            };

            var minPolicyRunner = new PolicyRunner(minPolicy);
            var maxPolicyRunner = new PolicyRunner(maxPolicy);
            var orderPolicyRunner = new PolicyRunner(orderPolicy);

            var providers = new List<Provider> { provider1, provider2, provider3, provider4 };

            var minHotels = minPolicyRunner.GetHotelsFromProviders(providers);
            var maxHotels = maxPolicyRunner.GetHotelsFromProviders(providers);
            var orderHotels = orderPolicyRunner.GetHotelsFromProviders(providers);

            Console.ReadKey();
        }
    }
}