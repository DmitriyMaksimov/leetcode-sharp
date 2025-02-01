using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00085Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00085();
        Assert.That(sut.MaximalRectangle([
            ['1', '0', '1', '0', '0'], ['1', '0', '1', '1', '1'], ['1', '1', '1', '1', '1'], ['1', '0', '0', '1', '0']
        ]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00085();
        Assert.That(sut.MaximalRectangle([['0']]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00085();
        Assert.That(sut.MaximalRectangle([['1']]), Is.EqualTo(1));
    }
}