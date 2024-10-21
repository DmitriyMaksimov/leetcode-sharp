using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01593Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01593();
        sut.MaxUniqueSplit("ababccc").Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01593();
        sut.MaxUniqueSplit("aba").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01593();
        sut.MaxUniqueSplit("aa").Should().Be(1);
    }
}
