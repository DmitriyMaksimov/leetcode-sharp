using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00739Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00739();

        sut.DailyTemperatures(new[] {73, 74, 75, 71, 69, 72, 76, 73}).Should().BeEquivalentTo(new[] {1, 1, 4, 2, 1, 1, 0, 0});
    }

    [Test]
    public void T2()
    {
        var sut = new S00739();

        sut.DailyTemperatures(new[] {30, 40, 50, 60}).Should().BeEquivalentTo(new[] {1, 1, 1, 0});
    }

    [Test]
    public void T3()
    {
        var sut = new S00739();

        sut.DailyTemperatures(new[] {30,60,90}).Should().BeEquivalentTo(new[] {1, 1, 0});
    }
}