using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02815Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02815();
        Assert.That(sut.MaxSum([51, 71, 17, 24, 42]), Is.EqualTo(88));
    }

    [Test]
    public void T2()
    {
        var sut = new S02815();
        Assert.That(sut.MaxSum([1, 2, 3, 4]), Is.EqualTo(-1));
    }
}