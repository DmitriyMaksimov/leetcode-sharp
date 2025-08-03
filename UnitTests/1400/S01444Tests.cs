using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01444Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01444();
        Assert.That(sut.Ways(["A..", "AAA", "..."], 3), Is.EqualTo(3));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01444();
        Assert.That(sut.Ways(["A..", "AA.", "..."], 3), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01444();
        Assert.That(sut.Ways(["A..", "A..", "..."], 1), Is.EqualTo(1));
    }
}