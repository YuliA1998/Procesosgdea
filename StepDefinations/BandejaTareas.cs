using Proceso_168016__sgdetest.Hooks;
using Proceso_168016__sgdetest.PageObjects;
using System;
using TechTalk.SpecFlow;
using Proceso_168016__sgdetest.TestData;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Proceso_168016__sgdetest.StepDefinations
{
    [Binding]
    class BandejaTareas
    {

        [When(@"Cambie al frame (.*)")]
        public void WhenCambieAlFrameX(string elemvaluefind)
        {
            TimeSpan.FromSeconds(10);
            EntityClass ele = JsonClass.Get_entity(elemvaluefind);
            var eleText = FindElemenstClass.GetDriver(ele.GetFieldBy, ele.ValueToFind);
        }

        [Then(@"Escribo en el campo (.*) ingreso (.*)")]
        public void ThenEscriboEnElCampoXIngresoY(string elemvaluefind, string text)
        {
            TimeSpan.FromSeconds(10);
            EntityClass ele = JsonClass.Get_entity(elemvaluefind);
            var eleText = FindElemenstClass.GetElement(ele.GetFieldBy, ele.ValueToFind);


            CustomBaseClass.EnterText3(eleText, text);
        }

        [When(@"subo el archivo (.*) en en el campo (.*)")]
        public void WhenSuboElArchivoXEnEnElCampoY(string elemvaluefind, string text)
        {
            TimeSpan.FromSeconds(10);
            EntityClass ele = JsonClass.Get_entity(elemvaluefind);
            var eleText = FindElemenstClass.GetElement(ele.GetFieldBy, ele.ValueToFind);


            CustomBaseClass.CargarArchivo(eleText, text);
        }

        [When(@"salir del iframe")]
        public void WhenSalirDelIframe()
        {
            FindElemenstClass._driver.SwitchTo().ParentFrame();
        }

        [When(@"pegar referencia del caso (.*)")]
        public void WhenPegarReferenciaDelCasoV(String elemvaluefind)
        {
            TimeSpan.FromSeconds(10);
            EntityClass ele = JsonClass.Get_entity(elemvaluefind);
            var eleText = FindElemenstClass.GetElement(ele.GetFieldBy, ele.ValueToFind);


            CustomBaseClass.ctrlv(eleText);
        }
    }
}
