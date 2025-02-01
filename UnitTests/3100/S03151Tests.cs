using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03151Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03151();
        Assert.That(sut.IsArraySpecial([1]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03151();
        Assert.That(sut.IsArraySpecial([2, 1, 4]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S03151();
        Assert.That(sut.IsArraySpecial([4, 3, 1, 6]), Is.False);
    }
}
