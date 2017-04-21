using NUnit.Framework;

namespace Calimno.Web.Tests
{
	[TestFixture]
    public class SampleTests
    {
	    [Test]
	    public void OneEqualsOne()
	    {
		    Assert.AreEqual(1,1);
	    }

	    [Test]
	    public void ZeroNotEqualOne()
	    {
		    Assert.AreNotEqual(0,1);
	    }
    }
}
