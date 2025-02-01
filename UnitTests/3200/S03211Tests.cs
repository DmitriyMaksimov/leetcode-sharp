using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03211Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03211();
        Assert.That(sut.ValidStrings(3), Is.EquivalentTo((string[]) ["010", "011", "101", "110", "111"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03211();
        Assert.That(sut.ValidStrings(1), Is.EquivalentTo((string[]) ["0", "1"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03211();
        Assert.That(sut.ValidStrings(18), Has.Count.EqualTo(6765));
    }
}
