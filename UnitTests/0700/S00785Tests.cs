using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00785Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00785();
        Assert.That(sut.IsBipartite(new[] {new[] {1, 2, 3}, new[] {0, 2}, new[] {0, 1, 3}, new[] {0, 2}}), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S00785();
        Assert.That(sut.IsBipartite(new[] {new[] { 1,3}, new []{0,2}, new []{1,3}, new []{0,2}}), Is.True);
    }
}
