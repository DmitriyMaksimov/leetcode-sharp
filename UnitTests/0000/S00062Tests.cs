using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00062Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00062();
        sut.UniquePaths(3, 7).Should().Be(28);
    }

    [Test]
    public void T2()
    {
        var sut = new S00062();
        sut.UniquePaths(3, 2).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00062();
        sut.UniquePaths(1, 1).Should().Be(1);
    }

    [Test]
    public void T4()
    {
        var sut = new S00062();
        sut.UniquePaths(1, 2).Should().Be(1);
    }

    [Test]
    public void T5()
    {
        var sut = new S00062();
        sut.UniquePaths(2, 1).Should().Be(1);
    }
}