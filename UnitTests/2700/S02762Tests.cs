using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02762Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02762();
        Assert.That(sut.ContinuousSubarrays([5, 4, 2, 4]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02762();
        Assert.That(sut.ContinuousSubarrays([1, 2, 3]), Is.EqualTo(6));
    }
}
