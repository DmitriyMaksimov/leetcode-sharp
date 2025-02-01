using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02485Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02485();
        Assert.That(sut.PivotInteger(8), Is.EqualTo(6));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02485();
        Assert.That(sut.PivotInteger(1), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02485();
        Assert.That(sut.PivotInteger(4), Is.EqualTo(-1));
    }
}