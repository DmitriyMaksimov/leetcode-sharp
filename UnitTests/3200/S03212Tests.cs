using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03212Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03212();
        sut.NumberOfSubmatrices([['X', 'X'], ['X', 'Y']]).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S03212();
        sut.NumberOfSubmatrices([['X', 'Y', '.'], ['Y', '.', '.']]).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S03212();
        sut.NumberOfSubmatrices([['.', '.'], ['.', '.']]).Should().Be(0);
    }
}
