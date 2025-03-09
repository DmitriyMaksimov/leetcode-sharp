using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03461Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03461();
        Assert.That(sut.HasSameDigits("3902"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03461();
        Assert.That(sut.HasSameDigits("34789"), Is.False);
    }
}
