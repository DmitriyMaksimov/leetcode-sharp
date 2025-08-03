using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00486Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00486();
        Assert.That(sut.PredictTheWinner([1, 5, 2]), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S00486();
        Assert.That(sut.PredictTheWinner([1, 5, 233, 7]), Is.True);
    }
}
