using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02525Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02525();
        Assert.That(sut.CategorizeBox(1000, 35, 700, 300), Is.EqualTo("Heavy"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02525();
        Assert.That(sut.CategorizeBox(200, 50, 800, 50), Is.EqualTo("Neither"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02525();
        Assert.That(sut.CategorizeBox(3223, 1271, 2418, 749), Is.EqualTo("Both"));
    }
}