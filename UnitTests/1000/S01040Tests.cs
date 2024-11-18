using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01040Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01040();
        sut.NumMovesStonesII([7, 4, 9]).Should().Equal(1, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01040();
        sut.NumMovesStonesII([6, 5, 4, 3, 10]).Should().Equal(2, 3);
    }
}
