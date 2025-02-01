using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01292Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01292();
        Assert.That(sut.MaxSideLength([[1, 1, 3, 2, 4, 3, 2], [1, 1, 3, 2, 4, 3, 2], [1, 1, 3, 2, 4, 3, 2]], 4), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01292();
        Assert.That(sut.MaxSideLength([[2, 2, 2, 2, 2], [2, 2, 2, 2, 2], [2, 2, 2, 2, 2], [2, 2, 2, 2, 2], [2, 2, 2, 2, 2]], 1), Is.EqualTo(0));
    }
}
