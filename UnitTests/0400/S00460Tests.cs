using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00460Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00460.LFUCache(2);
        
        sut.Put(1, 1);
        sut.Put(2, 2);
        Assert.That(sut.Get(1), Is.EqualTo(1));

        sut.Put(3, 3);
        Assert.That(sut.Get(2), Is.EqualTo(-1));

        Assert.That(sut.Get(3), Is.EqualTo(3));

        sut.Put(4, 4);
        Assert.That(sut.Get(1), Is.EqualTo(-1));
        Assert.That(sut.Get(3), Is.EqualTo(3));
        Assert.That(sut.Get(4), Is.EqualTo(4));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00460.LFUCache(2);
        
        sut.Put(3, 1);
        sut.Put(2, 1);
        sut.Put(2, 2);
        sut.Put(4, 4);
        Assert.That(sut.Get(2), Is.EqualTo(2));
    }
}