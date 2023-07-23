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
        sut.Compress(chars).Should().Be(6);
        chars.Should().StartWith(new []{'a', '2', 'b', '2', 'c', '3'});
    }

    [Test]
    public void T2()
    {
        var sut = new S00443();
        var chars = new[] {'a'};
        sut.Compress(chars).Should().Be(1);
        chars.Should().StartWith(new []{'a'});
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00443();
        var chars = new[] {'a','b','b','b','b','b','b','b','b','b','b','b','b'};
        sut.Compress(chars).Should().Be(4);
        chars.Should().StartWith(new []{'a','b','1','2'});
    }
}