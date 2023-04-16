using leetcode_sharp._0000;

namespace UnitTests;

[TestFixture]
public class S00033Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00033();
        sut.Search(new[] {4, 5, 6, 7, 0, 1, 2}, 0).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00033();
        sut.Search(new[] {4, 5, 6, 7, 0, 1, 2}, 3).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00033();
        sut.Search(new[] {1}, 0).Should().Be(-1);
    }
}