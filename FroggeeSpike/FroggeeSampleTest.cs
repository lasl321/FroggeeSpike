using System;
using Froggee.Framework;
using OpenQA.Selenium;

namespace Froggee.Framework.Sample
{
    public class FroggeeSampleTest : SeleniumTest
    {
        public override void Execute()
        {
            Open("http://froggeeframework.com");
            Pause(1000);
            Assert(Element(By.Id("converterBtn")).Click);
            var inputElement = WaitUntil(Elements(By.TagName("input")).At(1));
            Assert(Elements(By.TagName("input")).At(0).SendKeys(String.Format("This is {0} test", TestCase.Name)));
            Assert(Element(inputElement).Clear.SendKeys("Hello!"));
            Pause(2000);
            Assert(Element(inputElement).Clear.SendKeys("Welcome to Froggee Framework!"));
            Pause(2000);
            Assert(Element(inputElement).Clear.SendKeys("We hope you will like it! :)"));
            Pause(2000);
            GoBack();
            Pause(1000);
        }
    }
}
