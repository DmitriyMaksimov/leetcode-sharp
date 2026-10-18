using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S04048))]
public class S04048Tests
{
    [Test]
    public void T1()
    {
        var sut = new S04048();
        Assert.That(sut.CountSpecialIntegers([1, 8, 1, 5, 1, 5, 8, 5]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S04048();
        Assert.That(sut.CountSpecialIntegers([8, 8, 8, 8]), Is.Zero);
    }

    [Test]
    public void T3()
    {
        var sut = new S04048();
        Assert.That(sut.CountSpecialIntegers([8, 6, 6, 8, 8]), Is.Zero);
    }
}