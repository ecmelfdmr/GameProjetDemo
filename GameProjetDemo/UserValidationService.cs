using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjetDemo
{
    class UserValidationService : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.BirthYear == 1988 && gamer.FirstName == "Leyla" && gamer.LastName == "Kaya" && gamer.IdentityNumber == "5654623488")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool NewGamer(NewGamer newGamer)
        {
            if (newGamer.BirthDay == 12 && newGamer.BirtMonth == 5 && newGamer.City == "Ankara")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
