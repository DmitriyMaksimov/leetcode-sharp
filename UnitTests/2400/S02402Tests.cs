using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02402Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02402();
        sut.MostBooked(2, [[0, 10], [1, 5], [2, 7], [3, 4]]).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S02402();
        sut.MostBooked(3, [[1, 20], [2, 10], [3, 5], [4, 9], [6, 8]]).Should().Be(1);
    }
}