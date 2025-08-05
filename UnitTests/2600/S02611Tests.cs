using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02611))]
public class S02611Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02611();
        Assert.That(sut.MiceAndCheese([1, 1, 3, 4], [4, 4, 1, 1], 2), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S02611();
        Assert.That(sut.MiceAndCheese([1, 1], [1, 1], 2), Is.EqualTo(2));
    }
}