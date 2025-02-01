using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02133Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02133();
        Assert.That(sut.CheckValid(new[] {new[] {1, 2, 3}, new[] {3, 1, 2}, new[] {2, 3, 1}}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02133();
        Assert.That(sut.CheckValid(new[] {new[] {1, 1, 1}, new[] {1, 2, 3}, new[] {1, 2, 3}}), Is.False);
    }
}
