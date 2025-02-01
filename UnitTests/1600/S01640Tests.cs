using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01640Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01640();
        Assert.That(sut.CanFormArray(new[] {15, 88}, new[] {new[] {88}, new[] {15}}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01640();
        Assert.That(sut.CanFormArray(new[] {49, 18, 16}, new[] {new[] {16, 18, 49}}), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01640();
        Assert.That(sut.CanFormArray(new[] {91, 4, 64, 78}, new[] {new[] {78}, new[] {4, 64}, new[] {91}}), Is.True);
    }
}
