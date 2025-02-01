using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02683Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02683();
        Assert.That(sut.DoesValidArrayExist([1, 1, 0]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02683();
        Assert.That(sut.DoesValidArrayExist([1, 1]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S02683();
        Assert.That(sut.DoesValidArrayExist([1, 0]), Is.False);
    }
}
