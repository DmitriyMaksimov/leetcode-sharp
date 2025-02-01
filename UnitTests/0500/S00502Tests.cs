using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00502Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00502();
        Assert.That(sut.FindMaximizedCapital(2, 0, new[] {1, 2, 3}, new[] {0, 1, 1}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00502();
        Assert.That(sut.FindMaximizedCapital(3, 0, new[] {1, 2, 3}, new[] {0, 1, 2}), Is.EqualTo(6));
    }
}