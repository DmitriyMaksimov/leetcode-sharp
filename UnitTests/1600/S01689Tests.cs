using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01689Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01689();
        sut.MinPartitions("32").Should().Be(3);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01689();
        sut.MinPartitions("82734").Should().Be(8);
    }

    [Test]
    public void T3()
    {
        var sut = new S01689();
        sut.MinPartitions("27346209830709182346").Should().Be(9);
    }
}