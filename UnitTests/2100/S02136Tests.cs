using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02136Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02136();
        Assert.That(sut.EarliestFullBloom([1, 2, 3, 2], [2, 1, 2, 1]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S02136();
        Assert.That(sut.EarliestFullBloom([1, 4, 3], [2, 3, 1]), Is.EqualTo(9));
    }

    [Test]
    public void T3()
    {
        var sut = new S02136();
        Assert.That(sut.EarliestFullBloom([1], [1]), Is.EqualTo(2));
    }
}