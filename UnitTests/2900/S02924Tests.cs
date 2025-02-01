using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02924Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02924();
        Assert.That(sut.FindChampion(3, [[0,1],[1,2]]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S02924();
        Assert.That(sut.FindChampion(4, [[0,2],[1,3],[1,2]]), Is.EqualTo(-1));
    }
}
