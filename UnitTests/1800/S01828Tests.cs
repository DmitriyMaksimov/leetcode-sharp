using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01828Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01828();
        sut.CountPoints(new[] {new[] {1, 3}, new[] {3, 3}, new[] {5, 3}, new[] {2, 2}},
                new[] {new[] {2, 3, 1}, new[] {4, 3, 1}, new[] {1, 1, 2}})
            .Should().Equal(3, 2, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01828();
        sut.CountPoints(new[] {new[] {1, 1}, new[] {2, 2}, new[] {3, 3}, new[] {4, 4}, new[] {5, 5}},
                new[] {new[] {1, 2, 2}, new[] {2, 2, 2}, new[] {4, 3, 2}, new[] {4, 3, 3}})
            .Should().Equal(2, 3, 2, 4);
    }
}