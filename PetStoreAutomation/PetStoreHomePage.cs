using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PetStoreAutomation
{
    public class PetStoreHomePage
    {
        public PetStoreHomePage()
        {
            ChromeDriver mybrowser = new ChromeDriver();
            mybrowser.Url = "https://petstore.octoperf.com/actions/Catalog.action";
            Console.WriteLine(mybrowser.Title);
        }
    }
}
