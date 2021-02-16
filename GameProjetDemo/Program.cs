using System;

namespace GameProjetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationService());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1998,
                FirstName = "Leyla",
                LastName = "Kaya",
                IdentityNumber = "5654623488"
            });
            gamerManager.Add(new NewGamer
            {
                BirthDay = 12,
                BirtMonth = 5,
                City = "Ankara"
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Order();
        }
    }
}
