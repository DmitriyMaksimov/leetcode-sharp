using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03349Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03349();
        Assert.That(sut.HasIncreasingSubarrays([2, 5, 7, 8, 9, 2, 3, 4, 3, 1], 3), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03349();
        Assert.That(sut.HasIncreasingSubarrays([1, 2, 3, 4, 4, 4, 4, 5, 6, 7], 5), Is.False);
    }
}
