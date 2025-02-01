using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00075Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00075();
        var nums = new[] {2, 0, 2, 1, 1, 0};
        sut.SortColors(nums);
        Assert.That(nums, Is.EqualTo((int[]) [0, 0, 1, 1, 2, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00075();
        var nums = new[] {2, 0, 1};
        sut.SortColors(nums);
        Assert.That(nums, Is.EqualTo((int[]) [0, 1, 2]));
    }
}