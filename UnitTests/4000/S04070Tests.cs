using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S04070))]
public class S04070Tests
{
    [Test]
    public void T1()
    {
        var sut = new S04070();
        Assert.That(sut.MinRotations("0192837465"), Is.EqualTo(25));
    }

    [Test]
    public void T2()
    {
        var sut = new S04070();
        Assert.That(sut.MinRotations("1200210200"), Is.EqualTo(12));
    }
}