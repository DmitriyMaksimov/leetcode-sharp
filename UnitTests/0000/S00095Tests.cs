using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00095Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00095();
        var trees = sut.GenerateTrees(3).Select(x => x.AsString()).ToList();
        Assert.That(trees, Has.Count.EqualTo(5));
        Assert.That(trees, Is.EquivalentTo((string[]) ["[1,null,2,null,3]", "[1,null,3,2]", "[2,1,3]", "[3,1,null,null,2]", "[3,2,null,1]"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00095();
        var trees = sut.GenerateTrees(1).Select(x => x.AsString()).ToList();
        Assert.That(trees, Has.Count.EqualTo(1));
        Assert.That(trees, Is.EquivalentTo((string[]) ["[1]"]));
    }
}
