using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01233Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01233();
        Assert.That(sut.RemoveSubfolders(["/a", "/a/b", "/c/d", "/c/d/e", "/c/f"]), Is.EqualTo((string[]) ["/a", "/c/d", "/c/f"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01233();
        Assert.That(sut.RemoveSubfolders(["/a", "/a/b/c", "/a/b/d"]), Is.EqualTo((string[]) ["/a"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01233();
        Assert.That(sut.RemoveSubfolders(["/a/b/c", "/a/b/ca", "/a/b/d"]), Is.EqualTo((string[]) ["/a/b/c", "/a/b/ca", "/a/b/d"]));
    }
}
