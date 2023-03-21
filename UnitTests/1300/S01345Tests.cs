using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01345Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01345();
        sut.MinJumps(new[] {100, -23, -23, 404, 100, 23, 23, 23, 3, 404}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01345();
        sut.MinJumps(new[] {7}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01345();
        sut.MinJumps(new[] {7, 6, 9, 6, 9, 6, 9, 7}).Should().Be(1);
    }
}