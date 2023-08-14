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
        sut.RemoveDuplicates(nums).Should().Be(5);
        nums[..5].Should().Equal(1, 1, 2, 2, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00080();
        var nums = new[] {0, 0, 1, 1, 1, 1, 2, 3, 3};
        sut.RemoveDuplicates(nums).Should().Be(7);
        nums[..7].Should().Equal(0, 0, 1, 1, 2, 3, 3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00080();
        var nums = new[] {1};
        sut.RemoveDuplicates(nums).Should().Be(1);
        nums.Should().Equal(1);
    }
}