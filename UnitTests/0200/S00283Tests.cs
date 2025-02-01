using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00283Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00283();
        var nums = new[] {0, 1, 0, 3, 12};
        sut.MoveZeroes(nums);
        Assert.That(nums, Is.EqualTo((int[]) [1, 3, 12, 0, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00283();
        var nums = new[] {1, 0, 0, 3, 12};
        sut.MoveZeroes(nums);
        Assert.That(nums, Is.EqualTo((int[]) [1, 3, 12, 0, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00283();
        var nums = new[] {0};
        sut.MoveZeroes(nums);
        Assert.That(nums, Is.EqualTo((int[]) [0]));
    }

    [Test]
    public void T4()
    {
        var sut = new S00283();
        var nums = new[] {1};
        sut.MoveZeroes(nums);
        Assert.That(nums, Is.EqualTo((int[]) [1]));
    }

    [Test]
    public void T5()
    {
        var sut = new S00283();
        var nums = new[] {2, 1};
        sut.MoveZeroes(nums);
        Assert.That(nums, Is.EqualTo((int[]) [2, 1]));
    }
}