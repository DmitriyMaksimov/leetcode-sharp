using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00942Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00942();
        Assert.That(sut.DiStringMatch("IDID"), Is.EqualTo((int[]) [0, 4, 1, 3, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00942();
        Assert.That(sut.DiStringMatch("III"), Is.EqualTo((int[]) [0, 1, 2, 3]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00942();
        Assert.That(sut.DiStringMatch("DDI"), Is.EqualTo((int[]) [3, 2, 0, 1]));
    }
}