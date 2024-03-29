using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02294Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02294();
        sut.PartitionArray([3, 6, 1, 2, 5], 2).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02294();
        sut.PartitionArray([1, 2, 3], 1).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02294();
        sut.PartitionArray([2, 2, 4, 5], 0).Should().Be(3);
    }
}