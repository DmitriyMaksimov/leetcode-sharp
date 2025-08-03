using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02605Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02605();
        Assert.That(sut.MinNumber([4, 1, 3], [5, 7]), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S02605();
        Assert.That(sut.MinNumber([3, 5, 2, 6], [3, 1, 7]), Is.EqualTo(3));
    }
}