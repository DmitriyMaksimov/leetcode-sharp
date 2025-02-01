using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01793Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01793();
        Assert.That(sut.MaximumScore(new[] {1, 4, 3, 7, 4, 5}, 3), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S01793();
        Assert.That(sut.MaximumScore(new[] {5, 5, 4, 5, 4, 1, 1, 1}, 0), Is.EqualTo(20));
    }
}