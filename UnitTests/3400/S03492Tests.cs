using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03492Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03492();
        Assert.That(sut.MaxContainers(2, 3, 15), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03492();
        Assert.That(sut.MaxContainers(3, 5, 20), Is.EqualTo(4));
    }
}
