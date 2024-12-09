using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01954Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01954();
        sut.MinimumPerimeter(1).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S01954();
        sut.MinimumPerimeter(13).Should().Be(16);
    }

    [Test]
    public void T3()
    {
        var sut = new S01954();
        sut.MinimumPerimeter(1000000000).Should().Be(5040);
    }
}
