
using System.Diagnostics;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace WAG_fast
{

    [SetUpFixture]
    public class Finalizer //:TestBase
    {

        [OneTimeTearDown]
        public void RunInTheEndOfAll()
        {
            WebDriverFactory.DismissAll();
        }

    }
}
