using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03206Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03206();
        Assert.That(sut.NumberOfAlternatingGroups([1, 1, 1]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S03206();
        Assert.That(sut.NumberOfAlternatingGroups([0, 1, 0, 0, 1]), Is.EqualTo(3));
    }
}