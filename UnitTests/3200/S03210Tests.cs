using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03210Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03210();
        sut.GetEncryptedString("dart", 3).Should().Be("tdar");
    }

    [Test]
    public void T2()
    {
        var sut = new S03210();
        sut.GetEncryptedString("aaa", 1).Should().Be("aaa");
    }
}