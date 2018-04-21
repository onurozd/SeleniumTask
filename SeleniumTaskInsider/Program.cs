using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTaskInsider
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            string link = @"http://www.amazon.com";
            driver.Navigate().GoToUrl(link);
            driver.FindElement(By.Id("nav-link-accountList")).Click();
            driver.FindElement(By.Id("ap_email")).SendKeys("rotibas@carbtc.net");
            driver.FindElement(By.Id("continue")).Click();
            driver.FindElement(By.Id("ap_password")).SendKeys("123456");
            driver.FindElement(By.Id("signInSubmit")).Click();
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("samsung");
            driver.FindElement(By.ClassName("nav-input")).Click();
            string page2 = @"https://www.amazon.com/s/ref=sr_pg_2?fst=p90x%3A1&rh=i%3Aaps%2Ck%3Asamsung&page=2&keywords=samsung&ie=UTF8&qid=1524268946";
            driver.Navigate().GoToUrl(page2);
            string pageThirdProduct = @"https://www.amazon.com/Official-Galaxy-Headphones-EO-IG955BSEGWW-Fone-Stuff/dp/B072J8XD3D/ref=sr_1_19?ie=UTF8&qid=1524275431&sr=8-19&keywords=samsung";
            driver.Navigate().GoToUrl(pageThirdProduct);
            driver.FindElement(By.Id("add-to-wishlist-button-submit")).Click();
            driver.Navigate().GoToUrl(pageThirdProduct);
            //driver.FindElement(By.XPath(".//*[@id = 'nav-flyout-accountList']/div[2]/div/div[1]/div[3]/div/a[2]")).Click();
            string pageWhishList = @"https://www.amazon.com/gp/registry/wishlist/newwl/ref=nav_wishlist_lists_2";
            driver.Navigate().GoToUrl(pageWhishList);
            //driver.FindElement(By.ClassName("a-declarative")).Click();
            //Silme işlemini yapacak id, class bulamadım... :(
        }
    }
}