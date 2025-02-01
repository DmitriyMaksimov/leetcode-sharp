using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03228Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03228();
        Assert.That(sut.MaxOperations("1001101"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03228();
        Assert.That(sut.MaxOperations("00111"), Is.EqualTo(0));
    }
}
