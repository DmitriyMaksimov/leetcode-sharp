using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02073Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02073();
        sut.TimeRequiredToBuy(new[] {2, 3, 2}, 2).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02073();
        sut.TimeRequiredToBuy(new[] {5, 1, 1, 1}, 0).Should().Be(8);
    }
}