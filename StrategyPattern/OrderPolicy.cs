namespace StrategyPattern
{
    public class OrderPolicy : IPolicy
    {
        public ICondition? Condition { get; set; }

        public List<Hotel> Exec(List<Provider> providers)
        {
            if (Condition is OrderCondition condition)
            {
                // like Sieve of Eratosthenes , we create a dictionary with all hotels and a flag that determines that if that hotel choosed or not !
                var hotels = providers.SelectMany(x => x.Hotels).DistinctBy(x => x.Name).ToDictionary(x => x.Name, x => false);
                var hotelList = new List<Hotel>();

                // condition.ProviderOrders is sorted
                foreach (var item in condition.ProviderOrders)
                {
                    var provider = providers.FirstOrDefault(x => x.ProviderId == item);
                    foreach (var hotel in provider!.Hotels)
                    {
                        if (hotels[hotel.Name] == false)
                        {
                            hotelList.Add(hotel);
                            hotels[hotel.Name] = true;
                        }
                    }
                }
                return hotelList;
            }
            else
            {
                return providers.First().Hotels;
            }
        }
    }
}
