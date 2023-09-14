using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02190Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02190();
        sut.MostFrequent(new[] {1, 100, 200, 1, 100}, 1).Should().Be(100);
    }

    [Test]
    public void T2()
    {
        var sut = new S02190();
        sut.MostFrequent(new[] {2, 2, 2, 2, 3}, 2).Should().Be(2);
    }
}