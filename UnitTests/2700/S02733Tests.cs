using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02733Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02733();
        sut.FindNonMinOrMax(new[] {3, 2, 1, 4}).Should().BeOneOf(2, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02733();
        Assert.That(sut.FindNonMinOrMax(new[] {1, 2}), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02733();
        Assert.That(sut.FindNonMinOrMax(new[] {2, 1, 3}), Is.EqualTo(2));
    }
}