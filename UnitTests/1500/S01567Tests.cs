using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01567Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01567();
        Assert.That(sut.GetMaxLen([1,-2,-3,4]), Is.EqualTo(4));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01567();
        Assert.That(sut.GetMaxLen([0,1,-2,-3,-4]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01567();
        Assert.That(sut.GetMaxLen([-1,-2,-3,0,1]), Is.EqualTo(2));
    }
}