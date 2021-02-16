using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjetDemo
{
    class OrderManager : CampaignManager
    {
        public void Order(Campaign campaign)
        {
            Console.WriteLine("Sold");
        }
    }
}
