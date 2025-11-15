using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03622))]
public class S03622Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03622();
        Assert.That(sut.CheckDivisibility(99), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03622();
        Assert.That(sut.CheckDivisibility(23), Is.False);
    }
}