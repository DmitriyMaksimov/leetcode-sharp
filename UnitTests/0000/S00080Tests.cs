using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00080Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00080();
        var nums = new[] {1, 1, 1, 2, 2, 3};
        Assert.That(sut.RemoveDuplicates(nums), Is.EqualTo(5));
        Assert.That(nums[..5], Is.EqualTo((int[]) [1, 1, 2, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00080();
        var nums = new[] {0, 0, 1, 1, 1, 1, 2, 3, 3};
        Assert.That(sut.RemoveDuplicates(nums), Is.EqualTo(7));
        Assert.That(nums[..7], Is.EqualTo((int[]) [0, 0, 1, 1, 2, 3, 3]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00080();
        var nums = new[] {1};
        Assert.That(sut.RemoveDuplicates(nums), Is.EqualTo(1));
        Assert.That(nums, Is.EqualTo((int[]) [1]));
    }
}