using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjetDemo
{
    class CampaignManager : ICampaignManager
    {
        public void Access(Campaign campaign)
        {
            Console.WriteLine("Successful");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Updated");
        }

        internal void Order()
        {
            Console.WriteLine("Sold");
        }
    }
}
