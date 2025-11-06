using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03607))]
public class S03607Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03607();
        Assert.That(sut.ProcessQueries(5, [[1, 2], [2, 3], [3, 4], [4, 5]], [[1, 3], [2, 1], [1, 1], [2, 2], [1, 2]]), Is.EqualTo([3, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03607();
        Assert.That(sut.ProcessQueries(3, [], [[1, 1], [2, 1], [1, 1]]), Is.EqualTo([1, -1]));
    }
}