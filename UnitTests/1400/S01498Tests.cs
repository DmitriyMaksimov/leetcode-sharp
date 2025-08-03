using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01498Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01498();
        Assert.That(sut.NumSubseq([3,5,6,7], 9), Is.EqualTo(4));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01498();
        Assert.That(sut.NumSubseq([3,3,6,8], 10), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01498();
        Assert.That(sut.NumSubseq([2,3,3,4,6,7], 12), Is.EqualTo(61));
    }
}