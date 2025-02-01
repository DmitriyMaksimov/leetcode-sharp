using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01725Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01725();
        Assert.That(sut.CountGoodRectangles(new[] {new[] {5, 8}, new[] {3, 9}, new[] {5, 12}, new[] {16, 5}}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01725();
        Assert.That(sut.CountGoodRectangles(new[] {new[] {2, 3}, new[] {3, 7}, new[] {4, 3}, new[] {3, 7}}), Is.EqualTo(3));
    }
}