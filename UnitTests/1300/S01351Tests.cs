using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01351Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01351();
        sut.CountNegatives(new[] {new[] {4, 3, 2, -1}, new[] {3, 2, 1, -1}, new[] {1, 1, -1, -2}, new[] {-1, -1, -2, -3}}).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S01351();
        sut.CountNegatives(new[] {new[] {3, 2}, new[] {1, 0}}).Should().Be(0);
    }
}