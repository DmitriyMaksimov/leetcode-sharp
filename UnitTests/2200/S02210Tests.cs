using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02210Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02210();
        Assert.That(sut.CountHillValley([2, 4, 1, 1, 6, 5]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02210();
        Assert.That(sut.CountHillValley([6, 6, 5, 5, 4, 1]), Is.EqualTo(0));
    }
}