using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03148))]
public class S03148Test
{
    [Test]
    public void T1()
    {
        var sut = new S03148();
        Assert.That(sut.MaxScore([[9, 5, 7, 3], [8, 9, 6, 1], [6, 7, 14, 3], [2, 5, 3, 1]]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S03148();
        Assert.That(sut.MaxScore([[4, 3, 2], [3, 2, 1]]), Is.EqualTo(-1));
    }
}