using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00436Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00436();
        Assert.That(sut.FindRightInterval([[1,2]]), Is.EqualTo((int[]) [-1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00436();
        Assert.That(sut.FindRightInterval([[3,4],[2,3],[1,2]]), Is.EqualTo((int[]) [-1,0,1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00436();
        Assert.That(sut.FindRightInterval([[1,4],[2,3],[3,4]]), Is.EqualTo((int[]) [-1,2,-1]));
    }
}
