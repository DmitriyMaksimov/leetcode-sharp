using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01386))]
public class S01386Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01386();
        Assert.That(sut.MaxNumberOfFamilies(3, [[1, 2], [1, 3], [1, 8], [2, 6], [3, 1], [3, 10]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01386();
        Assert.That(sut.MaxNumberOfFamilies(2, [[2, 1], [1, 8], [2, 6]]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01386();
        Assert.That(sut.MaxNumberOfFamilies(4, [[4, 3], [1, 4], [4, 6], [1, 7]]), Is.EqualTo(4));
    }
}