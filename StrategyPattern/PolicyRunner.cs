namespace StrategyPattern
{
    public class PolicyRunner
    {
        private readonly IPolicy policy;

        public PolicyRunner(IPolicy policy)
        {
            this.policy = policy;
        }

        public List<Hotel> GetHotelsFromProviders(List<Provider> providers)
        {
            if (policy == null)
            {
                Console.WriteLine("There is no policy set , please set a policy");
                return new List<Hotel>();
            }

            var res = policy.Exec(providers);
            return res;
        }
    }
}
