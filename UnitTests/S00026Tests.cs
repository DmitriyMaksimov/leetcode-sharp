using leetcode_sharp;

namespace UnitTests;

public class S00026UnitTests
{
    [Test]
    public void Test0()
    {
        var sut = new S00026();
        var nums = Array.Empty<int>();
        var newLen = sut.RemoveDuplicates(nums);
        newLen.Should().Be(0);
    }
    
    [Test]
    public void Test1()
    {
        var sut = new S00026();
        var nums = new[] {1, 1, 2};
        var newLen = sut.RemoveDuplicates(nums);
        newLen.Should().Be(2);
        nums[..newLen].Should().OnlyHaveUniqueItems();
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00026();
        var nums = new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
        var newLen = sut.RemoveDuplicates(nums);
        newLen.Should().Be(5);
        nums[..newLen].Should().OnlyHaveUniqueItems();
    }
}