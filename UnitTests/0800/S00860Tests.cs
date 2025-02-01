using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00860Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00860();
        Assert.That(sut.LemonadeChange(new[] {5, 5, 5, 10, 20}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00860();
        Assert.That(sut.LemonadeChange(new[] {5, 5, 10, 10, 20}), Is.False);
    }
}
