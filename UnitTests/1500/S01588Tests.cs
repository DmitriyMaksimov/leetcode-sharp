using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01588Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01588();
        Assert.That(sut.SumOddLengthSubarrays(new[] {1, 4, 2, 5, 3}), Is.EqualTo(58));
    }

    [Test]
    public void T2()
    {
        var sut = new S01588();
        Assert.That(sut.SumOddLengthSubarrays(new[] {1, 2}), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01588();
        Assert.That(sut.SumOddLengthSubarrays(new[] {10, 11, 12}), Is.EqualTo(66));
    }
}