using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Selenium {
    public class Selenium
    {
        IWebDriver webDriver;
        public static void Main(string[] args)
        {
            Selenium s = new Selenium();

            s.StartChromeDriver();
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

        }
        public void StartChromeDriver()
        {
            webDriver = new ChromeDriver("C://Users//denis//OneDrive//Desktop//internshipEvozon//Selenium_WebDriver//Selenium_WebDriver//Drivers");

            webDriver.Navigate().GoToUrl("http://qa1magento.dev.evozon.com");

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
    }
}