using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01504Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01504();
        Assert.That(sut.NumSubmat([[1, 0, 1], [1, 1, 0], [1, 1, 0]]), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S01504();
        Assert.That(sut.NumSubmat([[0, 1, 1, 0], [0, 1, 1, 1], [1, 1, 1, 0]]), Is.EqualTo(24));
    }
}
