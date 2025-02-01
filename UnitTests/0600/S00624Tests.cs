using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00624Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00624();
        Assert.That(sut.MaxDistance([[1, 2, 3], [4, 5], [1, 2, 3]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00624();
        Assert.That(sut.MaxDistance([[1], [1]]), Is.EqualTo(0));
    }
}
