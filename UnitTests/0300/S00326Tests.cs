using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00326Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00326();
        Assert.That(sut.IsPowerOfThree(27), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00326();
        Assert.That(sut.IsPowerOfThree(0), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00326();
        Assert.That(sut.IsPowerOfThree(-1), Is.False);
    }

}
