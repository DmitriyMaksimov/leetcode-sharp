using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00894Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00894();
        var trees = sut.AllPossibleFBT(7).Select(x => x.AsString()).ToList();;
        var expected = new[]
        {
            "[0,0,0,null,null,0,0,null,null,0,0]",
            "[0,0,0,null,null,0,0,0,0]",
            "[0,0,0,0,0,0,0]",
            "[0,0,0,0,0,null,null,null,null,0,0]",
            "[0,0,0,0,0,null,null,0,0]"
        };

        Assert.That(trees, Is.EquivalentTo(expected));
    }

    [Test]
    public void T2()
    {
        var sut = new S00894();
        var trees = sut.AllPossibleFBT(3).Select(x => x.AsString()).ToList();;
        var expected = new[]
        {
            "[0,0,0]"
        };

        Assert.That(trees, Is.EquivalentTo(expected));
    }
}
