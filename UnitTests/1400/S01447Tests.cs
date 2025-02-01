using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01447Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01447();
        Assert.That(sut.SimplifiedFractions(2), Is.EquivalentTo((string[]) ["1/2"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01447();
        Assert.That(sut.SimplifiedFractions(3), Is.EquivalentTo((string[]) ["1/2", "1/3", "2/3"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01447();
        Assert.That(sut.SimplifiedFractions(4), Is.EquivalentTo((string[]) ["1/2", "1/3", "1/4", "2/3", "3/4"]));
    }

    [Test]
    public void T4()
    {
        var sut = new S01447();
        Assert.That(sut.SimplifiedFractions(100), Has.Count.EqualTo(3043));
    }
}
