using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02248Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02248();
        Assert.That(sut.Intersection(new[] {new[] {3, 1, 2, 4, 5}, new[] {1, 2, 3, 4}, new[] {3, 4, 5, 6}}), Is.EqualTo((int[]) [3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02248();
        Assert.That(sut.Intersection(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}}), Is.Empty);
    }
}