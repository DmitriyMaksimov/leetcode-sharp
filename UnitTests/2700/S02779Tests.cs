using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02779Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02779();
        sut.MaximumBeauty([4, 6, 1, 2], 2).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02779();
        sut.MaximumBeauty([1, 1, 1, 1], 10).Should().Be(4);
    }
}
