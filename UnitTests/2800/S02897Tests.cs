using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02897))]
public class S02897Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02897();
        Assert.That(sut.MaxSum([2, 6, 5, 8], 2), Is.EqualTo(261));
    }

    [Test]
    public void T2()
    {
        var sut = new S02897();
        Assert.That(sut.MaxSum([4, 5, 4, 7], 3), Is.EqualTo(90));
    }
}