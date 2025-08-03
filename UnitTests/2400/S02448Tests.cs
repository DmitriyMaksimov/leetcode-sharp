using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02448Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02448();
        Assert.That(sut.MinCost([1, 3, 5, 2], [2, 3, 1, 14]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02448();
        Assert.That(sut.MinCost([2, 2, 2, 2, 2], [4, 2, 8, 1, 3]), Is.EqualTo(0));
    }
}