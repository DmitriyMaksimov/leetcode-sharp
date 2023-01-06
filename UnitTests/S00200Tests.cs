using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00200Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00200();
        sut.NumIslands(new[]
        {
            new[] {'1', '1', '1', '1', '0'},
            new[] {'1', '1', '0', '1', '0'},
            new[] {'1', '1', '0', '0', '0'},
            new[] {'0', '0', '0', '0', '0'}
        }).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00200();
        sut.NumIslands(new[]
        {
            new[] {'1','1','0','0','0'},
            new[] {'1','1','0','0','0'},
            new[] {'0','0','1','0','0'},
            new[] {'0','0','0','1','1'}
        }).Should().Be(3);
    }
}