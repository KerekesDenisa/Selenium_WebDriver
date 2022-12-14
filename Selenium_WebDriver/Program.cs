using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium {
    public class Selenium
    {
        IWebDriver webDriver;
        public static void Main(string[] args)
        {
            Selenium s = new Selenium();

            /*s.StartChromeDriver();
            s.FindTitle();
            s.FindURL();
            s.FindLogo();
            s.ClickLogo();
            s.NavigateToPage("WOMEN");
            s.NavigateBack();
            s.NavigateForward();
            s.Refresh();  
            s.Quit();

            s.StartChromeDriver();
            s.ClickAccount();
            s.Quit(); 

            s.StartChromeDriver();
            s.ListLanquages(1);
            s.Quit

            s.StartChromeDriver();
            s.ClearSearch();
            s.AddInSearch("woman");
            s.Quit();*/

            s.StartChromeDriver();
            s.ListNewProducts();
            s.Quit();

        }
        public void StartChromeDriver()
        {
            webDriver = new ChromeDriver("C://Users//denis//OneDrive//Desktop//internshipEvozon//Selenium_WebDriver//Selenium_WebDriver//Drivers");
            webDriver.Manage().Window.Maximize();
            //webDriver.Navigate().GoToUrl("http://qa1magento.dev.evozon.com");
            webDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com");
        }
        public void FindTitle()
        {
            Console.WriteLine("Title is: " + webDriver.Title);
        }

        public void FindURL()
        {
            string url = webDriver.Url;
            Console.WriteLine("URL este: " + url);
        }
        public void FindLogo()
        {
            IWebElement getLogo = webDriver.FindElement(By.CssSelector("#header > div > a > img.large"));
            Console.WriteLine("Logo is: " + getLogo);
        }
        public void ClickLogo()
        {
            IWebElement clickLogo = webDriver.FindElement(By.CssSelector("#header > div > a > img.large"));
            clickLogo.Click();
        }
        public void NavigateToPage(string name)
        {
            IList<IWebElement> productList = webDriver.FindElements(By.CssSelector("#nav > ol > li"));
            foreach (var i in productList) 
            {
                if (i.Text.Equals(name))
                {
                    Console.WriteLine(i);
                    i.Click();
                    break;
                }
            }
            //sau un switch case pt categories fiecare cu selectorul.
            //sau metode pt fiecare categories 
        }
        public void NavigateBack()
        {
            webDriver.Navigate().Back();
        }
        public void NavigateForward()
        {
            webDriver.Navigate().Forward();
        }
        public void Refresh()
        {
            webDriver.Navigate().Refresh();
        }
        public void Quit()
        {
            webDriver.Quit();
        }
        public void ClickAccount()
        {
            IWebElement clickLogo = webDriver.FindElement(By.CssSelector("#header > div > div.skip-links > div > a > span.label"));
            clickLogo.Click();
        }
        public void ListLanquages(int number)
        {
            IWebElement language = webDriver.FindElement(By.Id("select-language"));

            SelectElement l = new SelectElement(language);

            Console.WriteLine("Number Lanquages List " + l.Options.Count);

            l.SelectByIndex(number);
        }
        public void ClearSearch()
        {
            IWebElement searchBar = webDriver.FindElement(By.CssSelector("#search"));
            searchBar.Clear();
        }
        public void AddInSearch(string word)
        {
            IWebElement searchBar = webDriver.FindElement(By.CssSelector("#search"));
            searchBar.SendKeys(word);
            searchBar.Submit();
        }

        public void ListNewProducts()
        {
            IList<IWebElement> newProducts = webDriver.FindElements(By.CssSelector("body > div > div > div.main-container.col1-layout > div > div > div.std > div.widget.widget-new-products > div.widget-products > ul > li"));

            Console.WriteLine("Number NewProducts List " + newProducts.Count());

            foreach(var i in newProducts)
                Console.WriteLine(i);
        }
    }
}