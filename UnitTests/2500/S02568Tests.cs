using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02568Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02568();
        Assert.That(sut.MinImpossibleOR([2, 1]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02568();
        Assert.That(sut.MinImpossibleOR([5, 3, 2]), Is.EqualTo(1));
    }
}
