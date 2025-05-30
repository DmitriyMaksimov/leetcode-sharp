using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03335))]
public class S03335Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03335();
        Assert.That(sut.LengthAfterTransformations("abcyy", 2), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S03335();
        Assert.That(sut.LengthAfterTransformations("azbk", 1), Is.EqualTo(5));
    }
}
