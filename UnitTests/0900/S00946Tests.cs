using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00946Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00946();
        Assert.That(sut.ValidateStackSequences([1, 2, 3, 4, 5], [4, 5, 3, 2, 1]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00946();
        Assert.That(sut.ValidateStackSequences([1, 2, 3, 4, 5], [4, 3, 5, 1, 2]), Is.False);
    }
}
