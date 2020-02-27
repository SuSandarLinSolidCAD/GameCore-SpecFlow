using TechTalk.SpecFlow;

namespace GameCore.Specs
{
    [Binding]
    public class Hooks : Steps
    {
        [BeforeScenario("Elf")]
        public void BeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
