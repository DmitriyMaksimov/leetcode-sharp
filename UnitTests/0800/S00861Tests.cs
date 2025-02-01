using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00861Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00861();
        Assert.That(sut.MatrixScore([[0, 0, 1, 1], [1, 0, 1, 0], [1, 1, 0, 0]]), Is.EqualTo(39));
    }

    [Test]
    public void T2()
    {
        var sut = new S00861();
        Assert.That(sut.MatrixScore([[0]]), Is.EqualTo(1));
    }
}