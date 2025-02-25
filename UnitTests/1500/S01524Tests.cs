using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01524Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01524();
        Assert.That(sut.NumOfSubarrays([1, 3, 5]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01524();
        Assert.That(sut.NumOfSubarrays([2, 4, 6]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01524();
        Assert.That(sut.NumOfSubarrays([1, 2, 3, 4, 5, 6, 7]), Is.EqualTo(16));
    }
}
