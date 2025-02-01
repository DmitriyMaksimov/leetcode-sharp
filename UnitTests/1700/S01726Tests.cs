using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01726Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01726();
        Assert.That(sut.TupleSameProduct([2, 3, 4, 6]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S01726();
        Assert.That(sut.TupleSameProduct([1, 2, 4, 5, 10]), Is.EqualTo(16));
    }
}
