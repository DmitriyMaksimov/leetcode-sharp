using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00944Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00944();
        Assert.That(sut.MinDeletionSize(new[] {"cba","daf","ghi"}), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00944();
        Assert.That(sut.MinDeletionSize(new[] {"a","b"}), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00944();
        Assert.That(sut.MinDeletionSize(new[] {"zyx","wvu","tsr"}), Is.EqualTo(3));
    }
}