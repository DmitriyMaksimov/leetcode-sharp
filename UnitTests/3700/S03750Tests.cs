using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03750))]
public class S03750Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03750();
        Assert.That(sut.MinimumFlips(7), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S03750();
        Assert.That(sut.MinimumFlips(10), Is.EqualTo(4));
    }
}