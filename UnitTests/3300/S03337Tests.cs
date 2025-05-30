using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03337))]
public class S03337Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03337();
        Assert.That(sut.LengthAfterTransformations("abcyy", 2, [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S03337();
        Assert.That(sut.LengthAfterTransformations("azbk", 1, [2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2]), Is.EqualTo(8));
    }
}
