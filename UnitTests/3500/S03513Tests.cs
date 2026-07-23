using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03513))]
public class S03513Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03513();
        Assert.That(sut.UniqueXorTriplets([1, 2]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03513();
        Assert.That(sut.UniqueXorTriplets([3, 1, 2]), Is.EqualTo(4));
    }
}