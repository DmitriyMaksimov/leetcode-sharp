using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00961Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00961();
        Assert.That(sut.RepeatedNTimes(new[] {1, 2, 3, 3}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00961();
        Assert.That(sut.RepeatedNTimes(new[] {2, 1, 2, 5, 3, 2}), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00961();
        Assert.That(sut.RepeatedNTimes(new[] {5, 1, 5, 2, 5, 3, 5, 4}), Is.EqualTo(5));
    }
}