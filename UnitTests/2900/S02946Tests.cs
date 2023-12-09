using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02946Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02946();
        sut.AreSimilar(new[] {new[] {1, 2, 1, 2}, new[] {5, 5, 5, 5}, new[] {6, 3, 6, 3}}, 2).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02946();
        sut.AreSimilar(new[] {new[] {2, 2}, new[] {2, 2}}, 3).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S02946();
        sut.AreSimilar(new[] {new[] {1, 2}}, 1).Should().BeFalse();
    }
}