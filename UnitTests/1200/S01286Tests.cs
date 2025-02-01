using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01286Tests
{
    [Test]
    public void T1()
    {
        var itr = new S01286.CombinationIterator("abc", 2);
        Assert.That(itr.Next(), Is.EqualTo("ab"));
        Assert.That(itr.HasNext(), Is.True);
        Assert.That(itr.Next(), Is.EqualTo("ac"));
        Assert.That(itr.HasNext(), Is.True);
        Assert.That(itr.Next(), Is.EqualTo("bc"));
        Assert.That(itr.HasNext(), Is.False);
    }

    [Test]
    public void T2()
    {
        var itr = new S01286.CombinationIterator("chp", 1);
        Assert.That(itr.Next(), Is.EqualTo("c"));
        Assert.That(itr.HasNext(), Is.True);
        Assert.That(itr.HasNext(), Is.True);
        Assert.That(itr.Next(), Is.EqualTo("h"));
        Assert.That(itr.Next(), Is.EqualTo("p"));
        Assert.That(itr.HasNext(), Is.False);
        Assert.That(itr.HasNext(), Is.False);
        Assert.That(itr.HasNext(), Is.False);
        Assert.That(itr.HasNext(), Is.False);
    }

    [Test]
    public void T3()
    {
        var itr = new S01286.CombinationIterator("bvwz", 2);
        Assert.That(itr.HasNext(), Is.True);
        Assert.That(itr.HasNext(), Is.True);
        Assert.That(itr.Next(), Is.EqualTo("bv"));
        Assert.That(itr.Next(), Is.EqualTo("bw"));
        Assert.That(itr.HasNext(), Is.True);
        Assert.That(itr.HasNext(), Is.True);
        Assert.That(itr.Next(), Is.EqualTo("bz"));
        Assert.That(itr.HasNext(), Is.True);
        Assert.That(itr.HasNext(), Is.True);
        Assert.That(itr.HasNext(), Is.True);
    }
}
