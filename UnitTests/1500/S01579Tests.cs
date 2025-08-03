using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01579Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01579();
        Assert.That(sut.MaxNumEdgesToRemove(4, [
            [3,1,2], [3,2,3], [1,1,3], [1,2,4], [1,1,2], [2,3,4]
        ]), Is.EqualTo(2));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01579();
        Assert.That(sut.MaxNumEdgesToRemove(4, [[3,1,2], [3,2,3], [1,1,4], [2,1,4]]), Is.EqualTo(0));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S01579();
        Assert.That(sut.MaxNumEdgesToRemove(4, [[3,2,3], [1,1,2], [2,3,4]]), Is.EqualTo(-1));
    }
}