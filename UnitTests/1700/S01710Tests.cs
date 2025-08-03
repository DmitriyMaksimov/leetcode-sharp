using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01710Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01710();
        Assert.That(sut.MaximumUnits([[1, 3], [2, 2], [3, 1]], 4), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S01710();
        Assert.That(sut.MaximumUnits([[5, 10], [2, 5], [4, 7], [3, 9]], 10), Is.EqualTo(91));
    }
}