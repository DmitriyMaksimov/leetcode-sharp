using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00944Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00944();
        sut.MinDeletionSize(new[] {"cba","daf","ghi"}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00944();
        sut.MinDeletionSize(new[] {"a","b"}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00944();
        sut.MinDeletionSize(new[] {"zyx","wvu","tsr"}).Should().Be(3);
    }
}