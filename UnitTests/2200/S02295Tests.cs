using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02295Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02295();
        Assert.That(sut.ArrayChange([1, 2, 4, 6], [[1, 3], [4, 7], [6, 1]]), Is.EqualTo((int[]) [3, 2, 7, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02295();
        Assert.That(sut.ArrayChange([1, 2], [[1, 3], [2, 1], [3, 2]]), Is.EqualTo((int[]) [2, 1]));
    }
}
