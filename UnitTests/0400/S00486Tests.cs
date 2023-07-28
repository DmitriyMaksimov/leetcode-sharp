using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00486Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00486();
        sut.PredictTheWinner(new[] {1, 5, 2}).Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S00486();
        sut.PredictTheWinner(new[] {1, 5, 233, 7}).Should().BeTrue();
    }
}