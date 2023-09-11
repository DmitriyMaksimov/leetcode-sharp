using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01779Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01779();
        sut.NearestValidPoint(3, 4, new[] {new[] {1, 2}, new[] {3, 1}, new[] {2, 4}, new[] {2, 3}, new[] {4, 4}})
            .Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01779();
        sut.NearestValidPoint(3, 4, new[] {new[] {3, 4}}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01779();
        sut.NearestValidPoint(3, 4, new[] {new[] {2, 3}}).Should().Be(-1);
    }
}