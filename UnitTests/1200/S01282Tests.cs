using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01282Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01282();
        Assert.That(sut.GroupThePeople([3, 3, 3, 3, 3, 1, 3]), Is.EquivalentTo([
            [5],
            [0, 1, 2],
            new [] {3, 4, 6}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01282();
        Assert.That(sut.GroupThePeople([2, 1, 3, 3, 3, 2]), Is.EquivalentTo([
            [1],
            [0, 5],
            new [] {2, 3, 4}
        ]));
    }
}