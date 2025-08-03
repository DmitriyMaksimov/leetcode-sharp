using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01887Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01887();
        Assert.That(sut.ReductionOperations([5, 1, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01887();
        Assert.That(sut.ReductionOperations([1, 1, 1]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01887();
        Assert.That(sut.ReductionOperations([1, 1, 2, 2, 3]), Is.EqualTo(4));
    }
}