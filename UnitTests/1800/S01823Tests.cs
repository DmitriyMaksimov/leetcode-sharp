using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01823Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01823();
        Assert.That(sut.FindTheWinner(5, 2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01823();
        Assert.That(sut.FindTheWinner(6, 5), Is.EqualTo(1));
    }
}