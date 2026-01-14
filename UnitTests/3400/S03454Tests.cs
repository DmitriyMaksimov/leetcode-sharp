using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03454))]
public class S03454Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03454();
        Assert.That(sut.SeparateSquares([[0, 0, 1], [2, 2, 1]]), Is.EqualTo(1).Within(1e-5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03454();
        Assert.That(sut.SeparateSquares([[0, 0, 2], [1, 1, 1]]), Is.EqualTo(1).Within(1e-5));
    }
    [Test]
    public void T3()
    {
        var sut = new S03454();
        Assert.That(sut.SeparateSquares([[0,0,9999999],[1000000000,0,9999999],[0,999999999,10000000],[0,1000000000,999999],[1000000000,1000000000,9999999]]), Is.EqualTo(1000000000).Within(1e-5));
    }
}