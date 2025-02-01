using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00189Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00189();
        var nums = new[] {1, 2, 3, 4, 5, 6, 7};
        sut.Rotate(nums, 3);
        Assert.That(nums, Is.EqualTo((int[]) [5, 6, 7, 1, 2, 3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00189();
        var nums = new[] {-1, -100, 3, 99};
        sut.Rotate(nums, 2);
        Assert.That(nums, Is.EqualTo((int[]) [3, 99, -1, -100]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00189();
        var nums = new[] {1, 2};
        sut.Rotate(nums, 3);
        Assert.That(nums, Is.EqualTo((int[]) [2, 1]));
    }
}