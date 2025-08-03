using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02614Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02614();
        Assert.That(sut.DiagonalPrime([[1, 2, 3], [5, 6, 7], [9, 10, 11]]), Is.EqualTo(11));
    }

    [Test]
    public void T2()
    {
        var sut = new S02614();
        Assert.That(sut.DiagonalPrime([[1, 2, 3], [5, 17, 7], [9, 11, 10]]), Is.EqualTo(17));
    }
}