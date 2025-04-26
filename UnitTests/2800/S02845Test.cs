using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02845))]
public class S02845Test
{
    [Test]
    public void T1()
    {
        var sut = new S02845();
        Assert.That(sut.CountInterestingSubarrays([3, 2, 4], 2, 1), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02845();
        Assert.That(sut.CountInterestingSubarrays([3, 1, 9, 6], 3, 0), Is.EqualTo(2));
    }
}
