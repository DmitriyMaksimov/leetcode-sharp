using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01882))]
public class S01882Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01882();
        Assert.That(sut.AssignTasks([3, 3, 2], [1, 2, 3, 2, 1, 2]), Is.EqualTo([2, 2, 0, 2, 1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01882();
        Assert.That(sut.AssignTasks([5, 1, 4, 3, 2], [2, 1, 2, 4, 5, 2, 1]), Is.EqualTo([1, 4, 1, 4, 1, 3, 2]));
    }
}