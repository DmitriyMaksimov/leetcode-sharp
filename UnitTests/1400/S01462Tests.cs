using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01462Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01462();
        Assert.That(sut.CheckIfPrerequisite(2, [[1, 0]], [[0, 1], [1, 0]]), Is.EqualTo((bool[]) [false, true]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01462();
        Assert.That(sut.CheckIfPrerequisite(2, [], [[1, 0], [0, 1]]), Is.EqualTo((bool[]) [false, false]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01462();
        Assert.That(sut.CheckIfPrerequisite(3, [[1, 2], [1, 0], [2, 0]], [[1, 0], [1, 2]]), Is.EqualTo((bool[]) [true, true]));
    }
}
