using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00809))]
public class S00809Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00809();
        Assert.That(sut.ExpressiveWords("heeellooo", ["hello", "hi", "helo"]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00809();
        Assert.That(sut.ExpressiveWords("zzzzzyyyyy", ["zzyy", "zy", "zyy"]), Is.EqualTo(3));
    }
}