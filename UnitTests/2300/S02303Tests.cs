using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02303Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02303();
        Assert.That(sut.CalculateTax(new[] {new[] {3, 50}, new[] {7, 10}, new[] {12, 25}}, 10), Is.EqualTo(2.65));
    }

    [Test]
    public void T2()
    {
        var sut = new S02303();
        Assert.That(sut.CalculateTax(new[] {new[] {1, 0}, new[] {4, 25}, new[] {5, 50}}, 2), Is.EqualTo(0.25));
    }

    [Test]
    public void T3()
    {
        var sut = new S02303();
        Assert.That(sut.CalculateTax(new[] {new[] {2, 50}}, 0), Is.EqualTo(0));
    }
}