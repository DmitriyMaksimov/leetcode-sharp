using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00886Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00886();
        sut.PossibleBipartition(4, new[] {new[] {1, 2}, new[] {1, 3}, new[] {2, 4}}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00886();
        sut.PossibleBipartition(3, new[] {new[] {1, 2}, new[] {1, 3}, new[] {2, 3}}).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00886();
        sut.PossibleBipartition(5, new[] {new[] {1, 2}, new[] {2, 3}, new[] {3, 4}, new[] {4, 5}, new[] {1, 5}}).Should().BeFalse();
    }

    [Test]
    public void T4()
    {
        var sut = new S00886();
        sut.PossibleBipartition(5, new[] {new[] {1, 2}, new[] {1, 3}, new[] {1, 4}, new[] {1, 5}, new[] {1, 5}}).Should().BeTrue();
    }

    [Test]
    public void T5()
    {
        var sut = new S00886();
        sut.PossibleBipartition(10, new[] {new[] {5, 9}, new[] {5, 10}, new[] {5, 6}, new[] {5, 7}, new[] {1, 5}, new[] {4, 5}, new[] {2, 5}, new[] {5, 8}, new[] {3, 5}})
            .Should().BeTrue();
    }
}