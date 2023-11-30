using OpenQA.Selenium;

namespace SkillIT.Interfaces
{
    internal interface IBrowserAdjuster
    {
        /// <summary>
        /// Set the zoom level of the browser
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="zoomPercentage"></param>
        void SetZoomLevelPercentage(WebDriver webDriver, int zoomPercentage);
    }
}
