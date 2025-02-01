using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01710Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01710();
        Assert.That(sut.MaximumUnits(new[] {new[] {1, 3}, new[] {2, 2}, new[] {3, 1}}, 4), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S01710();
        Assert.That(sut.MaximumUnits(new[] {new[] {5, 10}, new[] {2, 5}, new[] {4, 7}, new[] {3, 9}}, 10), Is.EqualTo(91));
    }
}