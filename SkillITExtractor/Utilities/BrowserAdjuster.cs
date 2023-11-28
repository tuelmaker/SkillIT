using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillIT
{
    internal class BrowserAdjuster
    {
        public static void AdjustBrowser()
        {
 
        }

        public static void SetMagnificationLevel(WebDriver webDriver)
        {
            WebElement html = (WebElement)webDriver.FindElement(By.TagName("html"));

            new Actions(webDriver)
                .SendKeys(html, $"{Keys.Control}{Keys.Add}{Keys.Null}")
                .Perform();
        }

        public static void ResetMagnificationLevel(WebDriver webDriver)
        {
            WebElement html = (WebElement)webDriver.FindElement(By.TagName("html"));

            new Actions(webDriver)
                .SendKeys(html, $"{Keys.Control}{Keys.NumberPad0}{Keys.Null}")
                .Perform();
        }

        public static void SetZoomLevelPercentage(WebDriver webDriver, int zoomPercentage)
        {
            webDriver.ExecuteScript($"document.body.style.zoom='{zoomPercentage}%'");
        }
    }
}
