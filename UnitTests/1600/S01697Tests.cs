using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01697Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01697();
        sut.DistanceLimitedPathsExist(3, new[] {new[] {0, 1, 2}, new[] {1, 2, 4}, new[] {2, 0, 8}, new[] {1, 0, 16}},
            new[] {new[] {0, 1, 2}, new[] {0, 2, 5}}).Should().Equal(false, true);
    }

    [Test]
    public void T2()
    {
        var sut = new S01697();
        sut.DistanceLimitedPathsExist(5, new[] {new[] {0, 1, 10}, new[] {1, 2, 5}, new[] {2, 3, 9}, new[] {3, 4, 13}},
            new[] {new[] {0, 4, 14}, new[] {1, 4, 13}}).Should().Equal(true, false);
    }
}