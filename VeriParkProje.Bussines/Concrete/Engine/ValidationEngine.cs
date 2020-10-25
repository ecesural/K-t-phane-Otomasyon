using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using VeriParkProje.Bussines.Interfaces;

namespace VeriParkProje.Bussines.Concrete.Engine
{
   public class ValidationEngine : IValidationService
    {
        public int CheckUrlHaveValueAndReturn(string requestPath)
        {
            try
            {
                var value = int.Parse(requestPath);
                return value;
            }
            catch
            {
                return 0;
            }
        }

        public string CheckModelHasErrorMessage(ICollection<ModelState> values)
        {
            foreach (var modelState in values)
            {
                foreach (var error in modelState.Errors)
                {
                    return error.ErrorMessage;
                }
            }
            return "";
        }

        
    }
}
