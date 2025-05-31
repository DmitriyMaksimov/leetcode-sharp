using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03550))]
public class S03550Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03550();
        Assert.That(sut.SmallestIndex([1, 3, 2]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03550();
        Assert.That(sut.SmallestIndex([1, 10, 11]), Is.EqualTo(1));
    }
}
