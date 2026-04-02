using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03418))]
public class S03418Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03418();
        Assert.That(sut.MaximumAmount([[0, 1, -1], [1, -2, 3], [2, -3, 4]]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S03418();
        Assert.That(sut.MaximumAmount([[10, 10, 10], [10, 10, 10]]), Is.EqualTo(40));
    }
}