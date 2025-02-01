using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02186Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02186();
        Assert.That(sut.MinSteps("leetcode", "coats"), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S02186();
        Assert.That(sut.MinSteps("night", "thing"), Is.EqualTo(0));
    }
}