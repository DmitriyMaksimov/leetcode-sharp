using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00031Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00031();
        var nums = new[] {1, 2, 3};
        sut.NextPermutation(nums);
        nums.Should().Equal(1, 3, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00031();
        var nums = new[] {3, 2, 1};
        sut.NextPermutation(nums);
        nums.Should().Equal(1, 2, 3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00031();
        var nums = new[] {1, 1, 5};
        sut.NextPermutation(nums);
        nums.Should().Equal(1, 5, 1);
    }
}