using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01601Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01601();
        sut.MaximumRequests(5,
            new[] {new[] {0, 1}, new[] {1, 0}, new[] {0, 1}, new[] {1, 2}, new[] {2, 0}, new[] {3, 4}}).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01601();
        sut.MaximumRequests(3, new[] {new[] {0, 0}, new[] {1, 2}, new[] {2, 1}}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01601();
        sut.MaximumRequests(4, new[] {new[] {0, 3}, new[] {3, 1}, new[] {1, 2}, new[] {2, 0}}).Should().Be(4);
    }
}