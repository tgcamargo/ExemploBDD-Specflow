using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace ExemploBDD.Specs
{
    [Binding]
    public sealed class ExemploBDDSeleniumStepDefinition
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        private static IWebDriver _Driver;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _Driver = new ChromeDriver();
            _Driver.Manage().Window.Maximize();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            if (_Driver != null)
            {
                _Driver.Dispose(); //dispose will run Quit() automatically for the driver
                _Driver = null;
            }
        }

        [Given(@"que eu entrei na tela inicial do site SpecFlow")]
        public void DadoQueEuEntreiNaTelaInicialDoSiteSpecFlow()
        {
            _Driver.Navigate().GoToUrl("http://specflow.org/");
            Assert.IsTrue(_Driver.Url.ToString().Equals("http://specflow.org/"));
        }

        [Given(@"cliquei no item ""(.*)"", no menu horizontal do topo")]
        public void DadoCliqueiNoItemNoMenuHorizontalDoTopo(string p0)
        {
            var opcaoMenu = _Driver.FindElements(By.ClassName("avia-menu-text"));

            for (int i = 0; i < opcaoMenu.Count; i++)
            {
                if(opcaoMenu[i].Text == p0)
                {
                    opcaoMenu[i].Click();
                    break;
                }
            }

            Assert.IsTrue(_Driver.Url.ToString().Equals("http://specflow.org/docs/"));

        }

        [When(@"eu clicar em ""(.*)""")]
        public void QuandoEuClicarEm(string p0)
        {
            var opcaoMenu = _Driver.FindElements(By.TagName("a"));

            for (int i = 0; i < opcaoMenu.Count; i++)
            {
                if (opcaoMenu[i].Text == p0)
                {
                    opcaoMenu[i].Click();
                    break;
                }
            }

            Assert.IsFalse(_Driver.Url.ToString().Equals("http://specflow.org/docs/"));
        }

        [Then(@"devo ser levado para a página da documentação sobre a instalação do SpecFlow\.")]
        public void EntaoDevoSerLevadoParaAPaginaDaDocumentacaoSobreAInstalacaoDoSpecFlow_()
        {
            Assert.IsTrue(_Driver.Url.ToString().Equals("http://specflow.org/documentation/Installation/"));
           
        }

        [Then(@"devo ser levado para a página de demonstração da configuração padrão do SpecFlow.")]
        public void EntaoDevoSerLevadoParaAPaginaDeDemonstracaoDaConfiguracaoPadraoDoSpecFlow()
        {
            Assert.IsTrue(_Driver.Url.ToString().Equals("http://specflow.org/documentation/Configuration/"));
            
        }
               
        [Then(@"devo ser levado para a página da documentação sobre Bindings do SpecFlow\.")]
        public void EntaoDevoSerLevadoParaAPaginaDaDocumentacaoSobreBindingsDoSpecFlow_()
        {
           Assert.IsTrue(_Driver.Url.ToString().Equals("http://specflow.org/documentation/Bindings/"));
           
        }

        [Then(@"devo ser levado para a página de FAQ do SpecFlow\.")]
        public void EntaoDevoSerLevadoParaAPaginaDeFAQDoSpecFlow_()
        {
            Assert.IsTrue(_Driver.Url.ToString().Equals("http://specflow.org/documentation/FAQ/"));
            
        }


    }
}
