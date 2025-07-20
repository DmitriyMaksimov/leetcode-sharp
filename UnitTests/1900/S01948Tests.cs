using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01948))]
public class S01948Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01948();
        Assert.That(sut.DeleteDuplicateFolder([["a"], ["c"], ["d"], ["a", "b"], ["c", "b"], ["d", "a"]]),
            Is.EquivalentTo([(string[])["d"], ["d", "a"]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01948();
        Assert.That(
            sut.DeleteDuplicateFolder([
                ["a"], ["c"], ["a", "b"], ["c", "b"], ["a", "b", "x"], ["a", "b", "x", "y"], ["w"], ["w", "y"]
            ]), Is.EquivalentTo([(string[])["c"], ["c", "b"], ["a"], ["a", "b"]]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01948();
        Assert.That(sut.DeleteDuplicateFolder([["a", "b"], ["c", "d"], ["c"], ["a"]]),
            Is.EquivalentTo([(string[])["c"], ["c", "d"], ["a"], ["a", "b"]]));
    }
}