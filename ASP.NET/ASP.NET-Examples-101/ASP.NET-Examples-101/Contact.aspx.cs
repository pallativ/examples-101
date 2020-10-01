using DependencyInjection.Services;
using System;
using System.Web.UI;
using Unity.Attributes;

namespace ASP.NET_Examples_101
{
    public partial class Contact : Page
    {
        private readonly IBusinessService businessService;


        /// <summary>
        ///  Injecting Dependency using Dependency Attributes...
        /// </summary>
        [Dependency]
        public IPersonService personService { get; set; }

        /// <summary>
        ///  Constructor Injection....
        /// </summary>
        public Contact(IBusinessService businessService)
        {
            this.businessService = businessService;
        }

        public string Result { get; set; }
        public string Result2 { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Result = businessService.Execute("Veera");
            Result2 = personService.Execute("Pallati");
        }
    }
}