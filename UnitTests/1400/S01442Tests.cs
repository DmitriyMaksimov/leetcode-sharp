using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01442Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01442();
        Assert.That(sut.CountTriplets([2, 3, 1, 6, 7]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01442();
        Assert.That(sut.CountTriplets([1, 1, 1, 1, 1]), Is.EqualTo(10));
    }
}