using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01282Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01282();
        Assert.That(sut.GroupThePeople(new[] {3, 3, 3, 3, 3, 1, 3}), Is.EquivalentTo(new []
        {
            new [] {5},
            new [] {0, 1, 2},
            new [] {3, 4, 6},
        }));
    }

    [Test]
    public void T2()
    {
        var sut = new S01282();
        Assert.That(sut.GroupThePeople(new[] {2, 1, 3, 3, 3, 2}), Is.EquivalentTo(new []
        {
            new [] {1},
            new [] {0, 5},
            new [] {2, 3, 4}
        }));
    }
}