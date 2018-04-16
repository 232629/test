using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.CustomElements
{
    public class NgCustomSelectElement
    {
        private readonly NgWebElement selectElement;
        private NgWebDriver ngWebDriver;

        public NgCustomSelectElement(NgWebElement select, NgWebDriver parrentNgWebDriver)
        {
            selectElement = select;
            ngWebDriver = parrentNgWebDriver;
        }

        public string GetValue()
        {
            return selectElement.Text.Replace("\r\n▼", "");
        }

        public string GetValueAfterClick()
        {
            //клик по селекту, ждем когда расскроется список

            selectElement.Click();
            var arrTagLi = selectElement.FindElement(By.CssSelector("select-dropdown>div>div.options")).FindElements(By.TagName("li"));

            foreach (var i in arrTagLi)
            {
                if (i.GetAttribute("class") == "highlighted selected")
                {
                    return i.Text; 
                }
            }
            return null;
        }

        public void SetValueAfterClick(string value)
        {
            //клик по селекту, ждем когда расскроется список
            selectElement.Click();
            var arrTagLi = selectElement.FindElement(By.CssSelector("select-dropdown>div>div.options")).FindElements(By.TagName("li"));

            foreach (var i in arrTagLi)
            {
                if (i.Text == value)
                {
                    //i.Click();            //Does not always work
                    ((IJavaScriptExecutor) ngWebDriver).ExecuteScript("arguments[0].click();", i);
                    return;
                }
            }
            throw new Exception("Element is " + value + " not found in dropdown.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void SetValueAfterClick(int value)
        {
            //клик по селекту, ждем когда расскроется список
            selectElement.Click();
            var arrTagLi = selectElement.FindElement(By.CssSelector("select-dropdown>div>div.options")).FindElements(By.TagName("li"));
            for (int i=0; i<arrTagLi.Count; i++)
            {
                if (i == value)
                {
                    //arrTagLi[i].Click();  //Does not always work
                    ((IJavaScriptExecutor)ngWebDriver).ExecuteScript("arguments[0].click();", arrTagLi[i]);
                    return;
                }
            }
            throw new Exception("Element is number = " + value + " not found in dropdown.");
        }

        public int Count()
        {
            //клик по селекту, ждем когда расскроется список
            selectElement.Click();
            var count = selectElement.FindElement(By.CssSelector("select-dropdown>div>div.options")).FindElements(By.TagName("li")).Count;
            selectElement.Click();
            return count;
        }

        public bool IsExist(string value)
        {
            //open list
            selectElement.Click();
            var arrTagLi = selectElement.FindElement(By.CssSelector("select-dropdown>div>div.options")).FindElements(By.TagName("li"));

            foreach (var i in arrTagLi)
            {
                if (i.Text == value)
                {
                    //close list
                    selectElement.Click();
                    return true;
                }
            }
            //close list
            selectElement.Click();
            return false;
        }


        public List<string> GetValuesList()
        {
            //open list
            selectElement.Click();
            var arrTagLi = selectElement.FindElement(By.CssSelector("select-dropdown>div>div.options")).FindElements(By.TagName("li"));
            List<string> arrValuesList  = new List<string>();

            foreach (var i in arrTagLi)
            {
                arrValuesList.Add(i.Text);
            }
            //close list
            selectElement.Click();
            return arrValuesList;
        }


    }
}
