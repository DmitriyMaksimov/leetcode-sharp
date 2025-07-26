using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03480))]
public class S03480Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03480();
        Assert.That(sut.MaxSubarrays(4, [[2, 3], [1, 4]]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S03480();
        Assert.That(sut.MaxSubarrays(5, [[1, 2], [2, 5], [3, 5]]), Is.EqualTo(12));
    }
}