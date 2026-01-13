using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03453))]
public class S03453Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03453();
        Assert.That(sut.SeparateSquares([[0, 0, 1], [2, 2, 1]]), Is.EqualTo(1).Within(1e-5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03453();
        Assert.That(sut.SeparateSquares([[0, 0, 2], [1, 1, 1]]), Is.EqualTo(1.16667).Within(1e-5));
    }
}