using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02444Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02444();
        sut.CountSubarrays(new[] {1, 3, 5, 2, 7, 5}, 1, 5).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02444();
        sut.CountSubarrays(new[] {1, 1, 1, 1}, 1, 1).Should().Be(10);
    }
}