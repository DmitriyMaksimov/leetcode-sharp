using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02366Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02366();
        Assert.That(sut.MinimumReplacement(new[] {1, 2, 3, 4, 5}), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S02366();
        Assert.That(sut.MinimumReplacement(new[] {3, 9, 3}), Is.EqualTo(2));
    }
}