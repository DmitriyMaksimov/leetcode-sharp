using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00733Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00733();
        sut.FloodFill(new[] {new[] {1, 1, 1}, new[] {1, 1, 0}, new[] {1, 0, 1}}, 1, 1, 2)
            .Should().BeEquivalentTo(new[] {new[] {2, 2, 2}, new[] {2, 2, 0}, new[] {2, 0, 1}});
    }

    [Test]
    public void T2()
    {
        var sut = new S00733();
        sut.FloodFill(new[] {new[] {0, 0, 0}, new[] {0, 0, 0}}, 0, 0, 0)
            .Should().BeEquivalentTo(new[] {new[] {0, 0, 0}, new[] {0, 0, 0}});
    }

    [Test]
    public void T3()
    {
        var sut = new S00733();
        sut.FloodFill(new[] {new[] {0, 0, 0}, new[] {1, 0, 0}}, 1, 0, 2)
            .Should().BeEquivalentTo(new[] {new[] {0, 0, 0}, new[] {2, 0, 0}});
    }
}