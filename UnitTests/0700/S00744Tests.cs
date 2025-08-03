using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00744Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00744();
        Assert.That(sut.NextGreatestLetter(['c', 'f', 'j'], 'a'), Is.EqualTo('c'));
    }

    [Test]
    public void T2()
    {
        var sut = new S00744();
        Assert.That(sut.NextGreatestLetter(['c', 'f', 'j'], 'c'), Is.EqualTo('f'));
    }

    [Test]
    public void T3()
    {
        var sut = new S00744();
        Assert.That(sut.NextGreatestLetter(['x', 'x', 'y', 'y'], 'z'), Is.EqualTo('x'));
    }
}