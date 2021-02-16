using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjetDemo
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
