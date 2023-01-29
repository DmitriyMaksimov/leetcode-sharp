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
        sut.Get(1).Should().Be(1);

        sut.Put(3, 3);
        sut.Get(2).Should().Be(-1);

        sut.Get(3).Should().Be(3);

        sut.Put(4, 4);
        sut.Get(1).Should().Be(-1);
        sut.Get(3).Should().Be(3);
        sut.Get(4).Should().Be(4);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00460.LFUCache(2);
        
        sut.Put(3, 1);
        sut.Put(2, 1);
        sut.Put(2, 2);
        sut.Put(4, 4);
        sut.Get(2).Should().Be(2);
    }
}