using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillIT
{
    /// <summary>
    /// Browser adjustment class
    /// </summary>
    internal class BrowserAdjuster
    {
        /// <summary>
        /// Set the zoom level of the browser
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="zoomPercentage"></param>
        public static void SetZoomLevelPercentage(WebDriver webDriver, int zoomPercentage)
        {
            webDriver.ExecuteScript($"document.body.style.zoom='{zoomPercentage}%'");
        }
    }
}
