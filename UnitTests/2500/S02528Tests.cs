using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02528))]
public class S02528Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02528();
        Assert.That(sut.MaxPower([1, 2, 4, 5, 0], 1, 2), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02528();
        Assert.That(sut.MaxPower([4, 4, 4, 4], 0, 3), Is.EqualTo(4));
    }
}