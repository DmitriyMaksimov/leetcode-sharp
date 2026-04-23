using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02615))]
public class S02615Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02615();
        Assert.That(sut.Distance([1, 3, 1, 1, 2]), Is.EqualTo([5, 0, 3, 4, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02615();
        Assert.That(sut.Distance([0, 5, 3]), Is.EqualTo([0, 0, 0]));
    }
}