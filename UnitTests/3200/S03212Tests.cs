using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03212Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03212();
        Assert.That(sut.NumberOfSubmatrices([['X', 'X'], ['X', 'Y']]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S03212();
        Assert.That(sut.NumberOfSubmatrices([['X', 'Y', '.'], ['Y', '.', '.']]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03212();
        Assert.That(sut.NumberOfSubmatrices([['.', '.'], ['.', '.']]), Is.EqualTo(0));
    }
}
