using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01284Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01284();
        sut.MinFlips(new[] {new[] {0, 0}, new[] {0, 1}}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01284();
        sut.MinFlips(new[] {new[] {0}}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01284();
        sut.MinFlips(new[] {new[] {1, 0, 0}, new[] {1, 0, 0}}).Should().Be(-1);
    }
}