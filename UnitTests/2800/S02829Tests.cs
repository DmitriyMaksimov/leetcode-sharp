using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02829Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02829();
        sut.MinimumSum(5, 4).Should().Be(18);
    }

    [Test]
    public void T2()
    {
        var sut = new S02829();
        sut.MinimumSum(2, 6).Should().Be(3);
    }
}
