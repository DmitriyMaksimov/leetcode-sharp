using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02799Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02799();
        Assert.That(sut.CountCompleteSubarrays([1, 3, 1, 2, 2]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02799();
        Assert.That(sut.CountCompleteSubarrays([5, 5, 5, 5]), Is.EqualTo(10));
    }
}
