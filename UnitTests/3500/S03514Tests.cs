using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03514))]
public class S03514Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03514();
        Assert.That(sut.UniqueXorTriplets([1, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03514();
        Assert.That(sut.UniqueXorTriplets([6, 7, 8, 9]), Is.EqualTo(4));
    }
}