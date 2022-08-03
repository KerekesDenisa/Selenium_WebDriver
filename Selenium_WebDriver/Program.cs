using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Selenium {
    public static class Selenium
    {
        public static void Main(string[] args)
        {
            IWebDriver webDriver = StartChromeDriver();



        }
        public static IWebDriver StartChromeDriver()
        {

            IWebDriver WebDriver = new ChromeDriver("C://Users//denis//OneDrive//Desktop//internshipEvozon//Selenium_WebDriver//Selenium_WebDriver//Drivers");

            WebDriver.Navigate().GoToUrl("http://qa1magento.dev.evozon.com");

            return WebDriver;
            
        }
        public static void FindTitle(IWebDriver WebDriver)
        {
            IWebElement getTitle = WebDriver.FindElement(By.CssSelector("#header > div > a > img.large"));
        }

    }
}