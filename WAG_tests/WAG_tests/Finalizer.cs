
using NUnit.Framework;

namespace WAG_fast
{

    [SetUpFixture]
    public class Finalizer
    {
         [OneTimeTearDown]    
       
        public void RunInTheEndOfAll()
        {
         WebDriverFactory.DismissAll();
        }
    }
}
