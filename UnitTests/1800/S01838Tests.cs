using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01838Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01838();
        sut.MaxFrequency(new[] {1, 2, 4}, 5).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01838();
        sut.MaxFrequency(new[] {1, 4, 8, 13}, 5).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01838();
        sut.MaxFrequency(new[] {3, 9, 6}, 2).Should().Be(1);
    }
}