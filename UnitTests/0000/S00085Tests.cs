using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00085Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00085();
        sut.MaximalRectangle([
            ['1', '0', '1', '0', '0'], ['1', '0', '1', '1', '1'], ['1', '1', '1', '1', '1'], ['1', '0', '0', '1', '0']
        ]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00085();
        sut.MaximalRectangle([['0']]).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00085();
        sut.MaximalRectangle([['1']]).Should().Be(1);
    }
}