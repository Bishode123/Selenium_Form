using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
           IWebElement element= driver.FindElement(By.Name("q"));
            element.Clear();
            element.SendKeys(txtURL.Text);
            element.Submit();
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
