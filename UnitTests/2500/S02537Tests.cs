using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02537Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02537();
        sut.CountGood([1, 1, 1, 1, 1], 10).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02537();
        sut.CountGood([3, 1, 4, 3, 2, 2, 4], 2).Should().Be(4);
    }
}
