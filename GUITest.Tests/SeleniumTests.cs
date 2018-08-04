using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace GUITest.Tests
{
    [TestClass]
    public class SeleniumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver("C://")
            {
                Url = "http://gazprom.ru"
            };
            var layout = driver.FindElementByClassName("layout");

            Assert.IsNotNull(layout);
        }
    }
}
