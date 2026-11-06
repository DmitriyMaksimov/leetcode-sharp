using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02747))]
public class S02747Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02747();
        Assert.That(sut.CountServers(3, [[1, 3], [2, 6], [1, 5]], 5, [10, 11]), Is.EqualTo([1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02747();
        Assert.That(sut.CountServers(3, [[2, 4], [2, 1], [1, 2], [3, 1]], 2, [3, 4]), Is.EqualTo([0, 1]));
    }
}