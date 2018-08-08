using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using System.Drawing.Imaging;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Spec2.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.IO;

using System.Text;
using TechTalk.SpecFlow.Tracing;
using System.Reflection;

namespace Spec2.Properties
{
    [Binding]
    public sealed class Hooks1
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        public  static IWebDriver Driver;
        public static ExtentTest test;

        static string Browser = Prop.Settings("browser").Value;
        static string baseurl = Prop.Settings("baseUrl").Value;

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void InitializeReport()
        {

            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\rache\source\repos\TravelCS\Spec2\Results\ExtentReport.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);


          }
        [AfterTestRun]
        public static void TearDown()
        {
            extent.Flush();

        }
        
        [BeforeFeature]
        public static void BeforeFeature()
        {
          
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
           
        }
        [AfterStep]
        public void InsertReportingSteps()
        {

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();


            Console.WriteLine(stepType);
          
            
                if (stepType.Equals("Given"))
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType.Equals("When"))
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType.Equals("Then"))
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType.Equals("And"))
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                     
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Before Scenario");
            if (Browser == "Firefox")
            {
                Console.Write("####### Feature : " + ScenarioContext.Current.ScenarioInfo.Title);


                Driver = new FirefoxDriver();
                ScenarioContext.Current["driver"] = Driver;

            }

            else if (Browser == "Chrome")
            {
                Console.Write("####### Feature : " + ScenarioContext.Current.ScenarioInfo.Title);

                Driver = new ChromeDriver();
                ScenarioContext.Current["driver"] = Driver;

            }
            else if (Browser == "IE")
            {
                Console.Write("####### Feature : " + ScenarioContext.Current.ScenarioInfo.Title);

                Driver = new InternetExplorerDriver();
                ScenarioContext.Current["driver"] = Driver;

            }
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
           
        }


        [AfterScenario]
        public void AfterWebTest()
        {
           
                if (ScenarioContext.Current.TestError != null)
                {
                    TakeScreenshot(Driver);
                }
            Console.WriteLine("quithem");
        
            Driver.Quit();
            Console.WriteLine("quit after");

        }

        private void TakeScreenshot(IWebDriver driver)
        {
            try
            {
                string fileNameBase = string.Format("error_{0}_{1}_{2}",
                                                    FeatureContext.Current.FeatureInfo.Title.ToIdentifier(),
                                                    ScenarioContext.Current.ScenarioInfo.Title.ToIdentifier(),
                                                    DateTime.Now.ToString("yyyyMMdd_HHmmss"));

                var artifactDirectory = Path.Combine(Directory.GetCurrentDirectory(), "testresults");
                if (!Directory.Exists(artifactDirectory))
                    Directory.CreateDirectory(artifactDirectory);

                string pageSource = driver.PageSource;
                string sourceFilePath = Path.Combine(artifactDirectory, fileNameBase + "_source.html");
                File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);
                Console.WriteLine("Page source: {0}", new Uri(sourceFilePath));

                ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;

                if (takesScreenshot != null)
                {
                    var screenshot = takesScreenshot.GetScreenshot();

                    string screenshotFilePath = Path.Combine(artifactDirectory, fileNameBase + "_screenshot.png");

                    screenshot.SaveAsFile(screenshotFilePath, format: ScreenshotImageFormat.Png);
                    Console.WriteLine("Screenshot: {0}", new Uri(screenshotFilePath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }
        }
    }
}
    