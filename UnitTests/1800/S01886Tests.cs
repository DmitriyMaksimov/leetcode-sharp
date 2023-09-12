using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01886Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01886();
        sut.FindRotation(new[] {new[] {0, 1}, new[] {1, 0}}, new[] {new[] {1, 0}, new[] {0, 1}}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01886();
        sut.FindRotation(new[] {new[] {0, 1}, new[] {1, 1}}, new[] {new[] {1, 0}, new[] {0, 1}}).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01886();
        sut.FindRotation(new[] {new[] {0, 0, 0}, new[] {0, 1, 0}, new[] {1, 1, 1}},
            new[] {new[] {1, 1, 1}, new[] {0, 1, 0}, new[] {0, 0, 0}}).Should().BeTrue();
    }
}