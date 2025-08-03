using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01128Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01128();
        Assert.That(sut.NumEquivDominoPairs([[1, 2], [2, 1], [3, 4], [5, 6]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01128();
        Assert.That(sut.NumEquivDominoPairs([[1, 2], [1, 2], [1, 1], [1, 2], [2, 2]]), Is.EqualTo(3));
    }
}