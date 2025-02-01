using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00168Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00168();
        Assert.That(sut.ConvertToTitle(1), Is.EqualTo("A"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00168();
        Assert.That(sut.ConvertToTitle(28), Is.EqualTo("AB"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00168();
        Assert.That(sut.ConvertToTitle(701), Is.EqualTo("ZY"));
    }

    [Test]
    public void T4()
    {
        var sut = new S00168();
        Assert.That(sut.ConvertToTitle(26), Is.EqualTo("Z"));
    }

}