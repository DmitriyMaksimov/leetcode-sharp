using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03637))]
public class S03637Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03637();
        Assert.That(sut.IsTrionic([1, 3, 5, 4, 2, 6]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03637();
        Assert.That(sut.IsTrionic([2, 1, 3]), Is.False);
    }
}