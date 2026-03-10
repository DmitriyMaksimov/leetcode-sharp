using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03130))]
public class S03130Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03130();
        Assert.That(sut.NumberOfStableArrays(1, 1, 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03130();
        Assert.That(sut.NumberOfStableArrays(1, 2, 1), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03130();
        Assert.That(sut.NumberOfStableArrays(3, 3, 2), Is.EqualTo(14));
    }
}