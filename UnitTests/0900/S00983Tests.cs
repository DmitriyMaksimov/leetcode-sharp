using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00983Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00983();
        sut.MincostTickets(new[] {1, 4, 6, 7, 8, 20}, new[] {2, 7, 15}).Should().Be(11);
    }

    [Test]
    public void T2()
    {
        var sut = new S00983();
        sut.MincostTickets(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31}, new[] {2, 7, 15}).Should().Be(17);
    }
}