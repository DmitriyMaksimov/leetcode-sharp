using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02383Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02383();
        Assert.That(sut.MinNumberOfHours(5, 3, new[] {1, 4, 3, 2}, new[] {2, 6, 3, 1}), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02383();
        Assert.That(sut.MinNumberOfHours(2, 4, new[] {1}, new[] {3}), Is.EqualTo(0));
    }
}