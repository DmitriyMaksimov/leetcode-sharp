using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02643Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02643();
        Assert.That(sut.RowAndMaximumOnes([[0, 1], [1, 0]]), Is.EqualTo((int[]) [0, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02643();
        Assert.That(sut.RowAndMaximumOnes([[0, 0, 0], [0, 1, 1]]), Is.EqualTo((int[]) [1, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02643();
        Assert.That(sut.RowAndMaximumOnes([[0, 0], [1, 1], [0, 0]]), Is.EqualTo((int[]) [1, 2]));
    }
}