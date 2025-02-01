using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00299Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00299();
        Assert.That(sut.GetHint("1807", "7810"), Is.EqualTo("1A3B"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00299();
        Assert.That(sut.GetHint("1123", "0111"), Is.EqualTo("1A1B"));
    }
}
