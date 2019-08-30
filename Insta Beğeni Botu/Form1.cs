using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Insta_Beğeni_Botu
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //   driver.Quit(); // tarayıcıyı kapatma
            //  driver.Dispose(); // tarayıcıyı kapatma
            // tarayıcı ve konsolu gizleme
          //  ChromeDriverService servis = ChromeDriverService.CreateDefaultService();
          //  servis.HideCommandPromptWindow = true;
          //  ChromeOptions ayar = new ChromeOptions();
          //  ayar.AddArgument("headless");
            //////////////////////////////////////////


            //IWebDriver driver = new ChromeDriver(servis, ayar);    
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromeDriverService servis = ChromeDriverService.CreateDefaultService();
            servis.HideCommandPromptWindow = true;
            ChromeOptions ayar = new ChromeOptions();
            ayar.AddArgument("disable-infobars");
                                             
            IWebDriver driver = new ChromeDriver(servis,ayar);
         
            
            for (; ; )
            {
                driver.Navigate().GoToUrl("https://yazbee.com/home");
                Thread.Sleep(3000);
                IWebElement id = driver.FindElement(By.Name("Email"));
                id.SendKeys(idd.Text);
                IWebElement pw = driver.FindElement(By.Name("Password"));
                pw.SendKeys(passw.Text);
                IWebElement buton = driver.FindElement(By.Name("btnLoginSubmit"));
                Thread.Sleep(1000);
                buton.Click();
                Thread.Sleep(2000);
                driver.Navigate().GoToUrl(urlgir.Text);
                Thread.Sleep(2500);
                IWebElement begeni = driver.FindElement(By.CssSelector("#postDetail > div.feed_content > div:nth-child(1) > div > div > div.postright > div.postbuttonsline > div:nth-child(3) > div.likebutton.postbutton.icon-heart"));
                begeni.Click(); 
                Thread.Sleep(2500);
                driver.Navigate().GoToUrl("https://yazbee.com/logout");
                Thread.Sleep(1500);
                button2_Click(button1, new EventArgs());
                listBox1.Items.Add("Beğeni işlemi tamamlandı.");
            }
        }
        int abc = -1;
        private void button2_Click(object sender, EventArgs e)
        {


            if (abc < idlist.Lines.Length)
            {
                idd.Text = idlist.Lines[abc + 1];
                abc++;
            }
            else
            {
                abc = -1;
            }         
            }
       
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
                button2_Click(button2, new EventArgs());
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            IWebDriver driver = new ChromeDriver();           

            for (; ; )
            {
                driver.Navigate().GoToUrl("https://yazbee.com/home");
                Thread.Sleep(3000);
                IWebElement id = driver.FindElement(By.Name("Email"));
                id.SendKeys(idd.Text);
                IWebElement pw = driver.FindElement(By.Name("Password"));
                pw.SendKeys(passw.Text);
                IWebElement buton = driver.FindElement(By.Name("btnLoginSubmit"));
                Thread.Sleep(1000);
                buton.Click();
                Thread.Sleep(2000);
                driver.Navigate().GoToUrl(urlgir.Text);
                Thread.Sleep(2500);
                IWebElement dislike = driver.FindElement(By.CssSelector("#postDetail > div.feed_content > div:nth-child(1) > div > div > div.postright > div.postbuttonsline > div:nth-child(4) > div.dislikebutton.postbutton.icon-brokenheart"));
                dislike.Click();
                Thread.Sleep(2500);
                driver.Navigate().GoToUrl("https://yazbee.com/logout");
                Thread.Sleep(1500);
                button2_Click(button1, new EventArgs());
                listBox1.Items.Add("Dislike işlemi tamamlandı.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            timer1.Enabled = true;
            timer1.Interval = 27000;

            for (; ; )
            {
                driver.Navigate().GoToUrl("https://yazbee.com/home");
                Thread.Sleep(3000);
                IWebElement id = driver.FindElement(By.Name("Email"));
                id.SendKeys(idd.Text);
                IWebElement pw = driver.FindElement(By.Name("Password"));
                pw.SendKeys(passw.Text);
                IWebElement buton = driver.FindElement(By.Name("btnLoginSubmit"));
                Thread.Sleep(1000);
                buton.Click();
                Thread.Sleep(2000);
                driver.Navigate().GoToUrl(urlgir.Text);
                Thread.Sleep(2500);
                IWebElement rt = driver.FindElement(By.CssSelector("#postDetail > div.feed_content > div:nth-child(1) > div > div > div.postright > div.postbuttonsline > div:nth-child(2) > div.postbutton.icon-citation"));
                rt.Click();              
                Thread.Sleep(2500);
                driver.Navigate().GoToUrl("https://yazbee.com/logout");
                Thread.Sleep(1500);
                button2_Click(button1, new EventArgs());
                listBox1.Items.Add("Alıntı işlemi tamamlandı.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            for (; ; )
            {
                driver.Navigate().GoToUrl("https://yazbee.com/login");
                Thread.Sleep(3000);
                IWebElement id = driver.FindElement(By.Name("Email"));
                id.SendKeys(idd.Text);
                IWebElement pw = driver.FindElement(By.Name("Password"));
                pw.SendKeys(passw.Text);
                IWebElement buton = driver.FindElement(By.Name("btnLoginSubmit"));
                Thread.Sleep(1000);
                buton.Click();
                Thread.Sleep(2000);
                driver.Navigate().GoToUrl("https://yazbee.com/"+ textBox2.Text);
                Thread.Sleep(1500);
                IWebElement takipet = driver.FindElement(By.CssSelector("body > div.profile_container > div.profile_specs.showonpc > div.specs_right > div > div.followbutton"));
                if (takipet.Text.Contains("Takibi Bırak"))
                {
                    takipet.Click();
                }
                else
                {
                    Thread.Sleep(3500);
                    driver.Navigate().GoToUrl("https://yazbee.com/logout");
                    Thread.Sleep(1500);
                    button2_Click(button1, new EventArgs());
                    listBox1.Items.Add("Takip etme işlemi tamamlandı.");
                }
                
                Thread.Sleep(3500);
                driver.Navigate().GoToUrl("https://yazbee.com/logout");
                Thread.Sleep(1500);
                button2_Click(button1, new EventArgs());
                listBox1.Items.Add("Takip etme işlemi tamamlandı.");
            }
        }
        string gonderi = "";
        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Resim Dosyaları |*.jpg;*.jpeg;*.png";
            file.Title = "Resim Seçin";  //yarım şuan, açtığım hesaplara resim ekletme kısmı 
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }              
            }
        }
    

