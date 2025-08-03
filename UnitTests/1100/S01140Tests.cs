using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01140Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01140();
        Assert.That(sut.StoneGameII([2, 7, 9, 4, 4]), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S01140();
        Assert.That(sut.StoneGameII([1, 2, 3, 4, 5, 100]), Is.EqualTo(104));
    }
}