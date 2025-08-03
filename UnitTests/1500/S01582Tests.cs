using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01582Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01582();
        Assert.That(sut.NumSpecial([[1, 0, 0], [0, 0, 1], [1, 0, 0]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01582();
        Assert.That(sut.NumSpecial([[1, 0, 0], [0, 1, 0], [0, 0, 1]]), Is.EqualTo(3));
    }
}