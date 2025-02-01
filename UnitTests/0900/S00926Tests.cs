using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00926Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00926();
        Assert.That(sut.MinFlipsMonoIncr("001100"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00926();
        Assert.That(sut.MinFlipsMonoIncr("010110"), Is.EqualTo(2));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00926();
        Assert.That(sut.MinFlipsMonoIncr("00011000"), Is.EqualTo(2));
    }
}