using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00553Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00553();
        Assert.That(sut.OptimalDivision([1000, 100, 10, 2]), Is.EqualTo("1000/(100/10/2)"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00553();
        Assert.That(sut.OptimalDivision([2, 3, 4]), Is.EqualTo("2/(3/4)"));
    }
}
