using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00761))]
public class S00761Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00761();
        Assert.That(sut.MakeLargestSpecial("11011000"), Is.EqualTo("11100100"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00761();
        Assert.That(sut.MakeLargestSpecial("10"), Is.EqualTo("10"));
    }
}