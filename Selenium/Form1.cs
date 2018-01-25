using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium
{
    public partial class Form1 : Form
    {

        IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          driver = new ChromeDriver();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            driver.Url = "http://www.google.com";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Forward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            driver.Navigate().Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            driver.Close();
            driver.Quit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            driver.Url = "D:/Users/Learning/Pictures/Screenshots/SampleForm.html";
            SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("Languages")));
            oSelection.SelectByText("Python");
            oSelection.SelectByIndex(2);
            IList<IWebElement> oSize = oSelection.Options;
            int iListSize = oSize.Count;
            for(int i=0;i<iListSize;i++)
            {
                String selectedValue = oSelection.Options.ElementAt(i).Text;
            }

            var elementTable = driver.FindElement(By.Id("mytable"));
            List<IWebElement> trElements = new List<IWebElement>(elementTable.FindElements(By.TagName("tr")));
            string strRowData = "";
            foreach(var trElement in trElements)
            {
                List<IWebElement> IstTdItem = new List<IWebElement>(trElement.FindElements(By.TagName("td")));

                foreach(var elemTd in IstTdItem)
                {
                    strRowData = strRowData + elemTd.Text + "\t \t";
                }
            }
            MessageBox.Show(strRowData);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            driver.Manage().Window.Minimize();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            driver.Manage().Window.Maximize();
        }
    }
}
