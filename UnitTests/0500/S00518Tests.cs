using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00518Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00518();
        sut.Change(5, new[] {1, 2, 5}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00518();
        sut.Change(3, new[] {2}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00518();
        sut.Change(10, new[] {10}).Should().Be(1);
    }
}