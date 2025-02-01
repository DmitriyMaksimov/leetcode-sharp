using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03179Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03179();
        Assert.That(sut.ValueAfterKSeconds(4, 5), Is.EqualTo(56));
    }

    [Test]
    public void T2()
    {
        var sut = new S03179();
        Assert.That(sut.ValueAfterKSeconds(5, 3), Is.EqualTo(35));
    }
}
