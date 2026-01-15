using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02943))]
public class S02943Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02943();
        Assert.That(sut.MaximizeSquareHoleArea(2, 1, [2, 3], [2]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02943();
        Assert.That(sut.MaximizeSquareHoleArea(1, 1, [2], [2]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S02943();
        Assert.That(sut.MaximizeSquareHoleArea(2, 3, [2, 3], [2, 4]), Is.EqualTo(4));
    }
}