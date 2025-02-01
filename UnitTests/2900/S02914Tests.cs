using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02914Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02914();
        Assert.That(sut.MinChanges("1001"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02914();
        Assert.That(sut.MinChanges("10"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02914();
        Assert.That(sut.MinChanges("0000"), Is.EqualTo(0));
    }
}
