using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjetDemo
{
    interface ICampaignManager
    {
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        void Access(Campaign campaign);
    }
}
