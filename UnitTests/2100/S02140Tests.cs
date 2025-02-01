using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02140Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02140();
        Assert.That(sut.MostPoints(new[] {new[] {3, 2}, new[] {4, 3}, new[] {4, 4}, new[] {2, 5}}), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02140();
        Assert.That(sut.MostPoints(new[] {new[] {1, 1}, new[] {2, 2}, new[] {3, 3}, new[] {4, 4}, new[] {5, 5}}), Is.EqualTo(7));
    }
}