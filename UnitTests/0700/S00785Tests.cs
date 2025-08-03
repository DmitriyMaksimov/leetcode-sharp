using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00785Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00785();
        Assert.That(sut.IsBipartite([[1, 2, 3], [0, 2], [0, 1, 3], [0, 2]]), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S00785();
        Assert.That(sut.IsBipartite([[1,3], [0,2], [1,3], [0,2]]), Is.True);
    }
}
