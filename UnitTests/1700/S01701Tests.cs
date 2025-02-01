using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01701Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01701();
        Assert.That(sut.AverageWaitingTime([[1, 2], [2, 5], [4, 3]]), Is.EqualTo(5).Within(1e-5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01701();
        Assert.That(sut.AverageWaitingTime([[5, 2], [5, 4], [10, 3], [20, 1]]), Is.EqualTo(3.25).Within(1e-5));
    }
}