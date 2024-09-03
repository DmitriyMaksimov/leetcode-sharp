using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00969Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00969();
        sut.PancakeSort([3, 2, 4, 1]).Should().Equal(3, 4, 2, 3, 1, 2, 1, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00969();
        sut.PancakeSort([1, 2, 3]).Should().Equal(3, 3, 2, 2, 1, 1);
    }
}
