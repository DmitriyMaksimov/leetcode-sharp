using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01845Tests
{
    [Test]
    public void T1()
    {
        var seatManager = new S01845.SeatManager(5);
        seatManager.Reserve().Should().Be(1);   // All seats are available, so return the lowest numbered seat, which is 1.
        seatManager.Reserve().Should().Be(2);   // The available seats are [2,3,4,5], so return the lowest of them, which is 2.
        seatManager.Unreserve(2);               // Unreserve seat 2, so now the available seats are [2,3,4,5].
        seatManager.Reserve().Should().Be(2);   // The available seats are [2,3,4,5], so return the lowest of them, which is 2.
        seatManager.Reserve().Should().Be(3);   // The available seats are [3,4,5], so return the lowest of them, which is 3.
        seatManager.Reserve().Should().Be(4);   // The available seats are [4,5], so return the lowest of them, which is 4.
        seatManager.Reserve().Should().Be(5);   // The only available seat is seat 5, so return 5.
        seatManager.Unreserve(5);               // Unreserve seat 5, so now the available seats are [5].
    }
}