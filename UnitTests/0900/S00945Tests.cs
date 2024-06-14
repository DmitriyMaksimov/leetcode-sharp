using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00945Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00945();
        sut.MinIncrementForUnique([1, 2, 2]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00945();
        sut.MinIncrementForUnique([3, 2, 1, 2, 1, 7]).Should().Be(6);
    }
}