using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00221Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00221();
        sut.MaximalSquare(new[] {new[] {'1', '0', '1', '0', '0'}, new[] {'1', '0', '1', '1', '1'}, new[] {'1', '1', '1', '1', '1'}, new[] {'1', '0', '0', '1', '0'}})
            .Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00221();
        sut.MaximalSquare(new[] {new[] {'0', '1'}, new[] {'1', '0'}}).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00221();
        sut.MaximalSquare(new[] {new[] {'0'}}).Should().Be(0);
    }
}