using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01353))]
public class S01353Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01353();
        Assert.That(sut.MaxEvents([[1, 2], [2, 3], [3, 4]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01353();
        Assert.That(sut.MaxEvents([[1, 2], [2, 3], [3, 4], [1, 2]]), Is.EqualTo(4));
    }
}