using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00217Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00217();
        Assert.That(sut.ContainsDuplicate([1, 2, 3, 1]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00217();
        Assert.That(sut.ContainsDuplicate([1, 2, 3, 4]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00217();
        Assert.That(sut.ContainsDuplicate([1,1,1,3,3,4,3,2,4,2]), Is.True);
    }
}
