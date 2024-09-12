using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02527Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02527();
        sut.XorBeauty([1, 4]).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S02527();
        sut.XorBeauty([15, 45, 20, 2, 34, 35, 5, 44, 32, 30]).Should().Be(34);
    }
}
