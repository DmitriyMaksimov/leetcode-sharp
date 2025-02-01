using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03210Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03210();
        Assert.That(sut.GetEncryptedString("dart", 3), Is.EqualTo("tdar"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03210();
        Assert.That(sut.GetEncryptedString("aaa", 1), Is.EqualTo("aaa"));
    }
}