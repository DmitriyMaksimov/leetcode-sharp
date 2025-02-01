using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00507Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00507();
        Assert.That(sut.CheckPerfectNumber(28), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00507();
        Assert.That(sut.CheckPerfectNumber(7), Is.False);
    }

}
