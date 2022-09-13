using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationComponent
{
    public class ValidationService : IValidationService
    {
        public bool IsValidated(string userName, string password)
        {
            return true;
        }
    }
}
