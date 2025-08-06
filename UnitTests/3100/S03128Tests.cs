using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03128))]
public class S03128Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03128();
        Assert.That(sut.NumberOfRightTriangles([[0, 1, 0], [0, 1, 1], [0, 1, 0]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03128();
        Assert.That(sut.NumberOfRightTriangles([[1, 0, 0, 0], [0, 1, 0, 1], [1, 0, 0, 0]]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03128();
        Assert.That(sut.NumberOfRightTriangles([[1, 0, 1], [1, 0, 0], [1, 0, 0]]), Is.EqualTo(2));
    }
}