using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02160Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02160();
        Assert.That(sut.MinimumSum(2932), Is.EqualTo(52));
    }

    [Test]
    public void T2()
    {
        var sut = new S02160();
        Assert.That(sut.MinimumSum(4009), Is.EqualTo(13));
    }
}