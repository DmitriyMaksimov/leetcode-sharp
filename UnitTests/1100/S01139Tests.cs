using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01139Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01139();
        Assert.That(sut.Largest1BorderedSquare([[1, 1, 1], [1, 0, 1], [1, 1, 1]]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S01139();
        Assert.That(sut.Largest1BorderedSquare([[1, 1, 0, 0]]), Is.EqualTo(1));
    }
}
