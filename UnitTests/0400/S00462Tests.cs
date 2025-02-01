using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00462Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00462();
        Assert.That(sut.MinMoves2([1, 2, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00462();
        Assert.That(sut.MinMoves2([1, 10, 2, 9]), Is.EqualTo(16));
    }
}
