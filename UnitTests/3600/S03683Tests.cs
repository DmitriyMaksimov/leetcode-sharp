using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03683))]
public class S03683Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03683();
        Assert.That(sut.EarliestTime([[1, 6], [2, 3]]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03683();
        Assert.That(sut.EarliestTime([[100, 100], [100, 100], [100, 100]]), Is.EqualTo(200));
    }
}