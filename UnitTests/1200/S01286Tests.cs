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
        itr.HasNext().Should().BeTrue();
        Assert.That(itr.Next(), Is.EqualTo("ac"));
        itr.HasNext().Should().BeTrue();
        Assert.That(itr.Next(), Is.EqualTo("bc"));
        itr.HasNext().Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var itr = new S01286.CombinationIterator("chp", 1);
        Assert.That(itr.Next(), Is.EqualTo("c"));
        itr.HasNext().Should().BeTrue();
        itr.HasNext().Should().BeTrue();
        Assert.That(itr.Next(), Is.EqualTo("h"));
        Assert.That(itr.Next(), Is.EqualTo("p"));
        itr.HasNext().Should().BeFalse();
        itr.HasNext().Should().BeFalse();
        itr.HasNext().Should().BeFalse();
        itr.HasNext().Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var itr = new S01286.CombinationIterator("bvwz", 2);
        itr.HasNext().Should().BeTrue();
        itr.HasNext().Should().BeTrue();
        Assert.That(itr.Next(), Is.EqualTo("bv"));
        Assert.That(itr.Next(), Is.EqualTo("bw"));
        itr.HasNext().Should().BeTrue();
        itr.HasNext().Should().BeTrue();
        Assert.That(itr.Next(), Is.EqualTo("bz"));
        itr.HasNext().Should().BeTrue();
        itr.HasNext().Should().BeTrue();
        itr.HasNext().Should().BeTrue();
    }
}