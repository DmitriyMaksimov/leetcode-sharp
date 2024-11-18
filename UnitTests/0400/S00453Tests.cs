using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00453Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00453();
        sut.MinMoves([1, 2, 3]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00453();
        sut.MinMoves([1, 1, 1]).Should().Be(0);
    }
}
