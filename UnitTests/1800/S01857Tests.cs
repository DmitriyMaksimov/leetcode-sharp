using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01857Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01857();
        Assert.That(sut.LargestPathValue("abaca", [[0, 1], [0, 2], [2, 3], [3, 4]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01857();
        Assert.That(sut.LargestPathValue("a", [[0, 0]]), Is.EqualTo(-1));
    }
}