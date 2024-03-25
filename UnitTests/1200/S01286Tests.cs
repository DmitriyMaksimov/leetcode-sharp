using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01286Tests
{
    [Test]
    public void T1()
    {
        var itr = new S01286.CombinationIterator("abc", 2);
        itr.Next().Should().Be("ab");
        itr.HasNext().Should().BeTrue();
        itr.Next().Should().Be("ac");
        itr.HasNext().Should().BeTrue();
        itr.Next().Should().Be("bc");
        itr.HasNext().Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var itr = new S01286.CombinationIterator("chp", 1);
        itr.Next().Should().Be("c");
        itr.HasNext().Should().BeTrue();
        itr.HasNext().Should().BeTrue();
        itr.Next().Should().Be("h");
        itr.Next().Should().Be("p");
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
        itr.Next().Should().Be("bv");
        itr.Next().Should().Be("bw");
        itr.HasNext().Should().BeTrue();
        itr.HasNext().Should().BeTrue();
        itr.Next().Should().Be("bz");
        itr.HasNext().Should().BeTrue();
        itr.HasNext().Should().BeTrue();
        itr.HasNext().Should().BeTrue();
    }
}