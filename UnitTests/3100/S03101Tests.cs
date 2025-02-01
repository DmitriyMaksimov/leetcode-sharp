using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03101Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03101();
        Assert.That(sut.CountAlternatingSubarrays([0, 1, 1, 1]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03101();
        Assert.That(sut.CountAlternatingSubarrays([1, 0, 1, 0]), Is.EqualTo(10));
    }
}
