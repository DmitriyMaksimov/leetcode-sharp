using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00443Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00443();
        var chars = new[] {'a', 'a', 'b', 'b', 'c', 'c', 'c'};
        Assert.That(sut.Compress(chars), Is.EqualTo(6));
        Assert.That(chars, Is.EquivalentTo((char[]) ['a', '2', 'b', '2', 'c', '3', 'c']));
    }

    [Test]
    public void T2()
    {
        var sut = new S00443();
        var chars = new[] {'a'};
        Assert.That(sut.Compress(chars), Is.EqualTo(1));
        Assert.That(chars, Is.EquivalentTo((char[]) ['a']));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00443();
        var chars = new[] {'a','b','b','b','b','b','b','b','b','b','b','b','b'};
        Assert.That(sut.Compress(chars), Is.EqualTo(4));
        Assert.That(chars, Is.EquivalentTo((char[]) ['a', 'b', '1', '2', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b']));
    }
}
