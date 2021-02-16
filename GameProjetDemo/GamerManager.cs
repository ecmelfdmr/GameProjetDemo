using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjetDemo
{
    //Micro Service
    class GamerManager : IGamerManager
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer added");
            }
            else
            {
                Console.WriteLine("Your signup failed!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted");
        }



        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated");
        }
    }
}
