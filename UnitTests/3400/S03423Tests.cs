using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03423Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03423();
        Assert.That(sut.MaxAdjacentDistance([1, 2, 4]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03423();
        Assert.That(sut.MaxAdjacentDistance([-5, -10, -5]), Is.EqualTo(5));
    }
}
