using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Services
{
    public interface IBusinessService
    {
        string Execute(string name);
    }
    public class BusinessService : IBusinessService
    {
        public string Execute(string name)
        {
            return string.Format("Hello {0}, from Business Service", name);
        }
    }
}