using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01588Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01588();
        sut.SumOddLengthSubarrays(new[] {1, 4, 2, 5, 3}).Should().Be(58);
    }

    [Test]
    public void T2()
    {
        var sut = new S01588();
        sut.SumOddLengthSubarrays(new[] {1, 2}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01588();
        sut.SumOddLengthSubarrays(new[] {10, 11, 12}).Should().Be(66);
    }
}