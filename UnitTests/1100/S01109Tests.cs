using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01109Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01109();
        Assert.That(sut.CorpFlightBookings([[1, 2, 10], [2, 3, 20], [2, 5, 25]], 5), Is.EqualTo((int[]) [10, 55, 45, 25, 25]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01109();
        Assert.That(sut.CorpFlightBookings([[1, 2, 10], [2, 2, 15]], 2), Is.EqualTo((int[]) [10, 25]));
    }
}
