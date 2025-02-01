using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00939Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00939();
        Assert.That(sut.MinAreaRect([[1, 1], [1, 3], [3, 1], [3, 3], [2, 2]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00939();
        Assert.That(sut.MinAreaRect([[1, 1], [1, 3], [3, 1], [3, 3], [4, 1], [4, 3]]), Is.EqualTo(2));
    }
}
