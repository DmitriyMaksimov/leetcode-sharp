using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02411))]
public class S02411Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02411();
        Assert.That(sut.SmallestSubarrays([1, 0, 2, 1, 3]), Is.EqualTo([3, 3, 2, 2, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02411();
        Assert.That(sut.SmallestSubarrays([1, 2]), Is.EqualTo([2, 1]));
    }
}