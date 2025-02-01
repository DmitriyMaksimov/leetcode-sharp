using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02215Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02215();
        var list = sut.FindDifference(new[] {1, 2, 3}, new[] {2, 4, 6});
        Assert.That(list, Has.Count.EqualTo(2));
        Assert.That(list[0], Is.EqualTo((int[]) [1, 3]));
        Assert.That(list[1], Is.EqualTo((int[]) [4, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02215();
        var list = sut.FindDifference(new[] {1, 2, 3, 3}, new[] {1, 1, 2, 2});
        Assert.That(list, Has.Count.EqualTo(2));
        Assert.That(list[0], Is.EqualTo((int[]) [3]));
        Assert.That(list[1], Is.Empty);
    }
}
