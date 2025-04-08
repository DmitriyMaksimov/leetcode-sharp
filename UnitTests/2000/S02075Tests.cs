using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02075Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02075();
        Assert.That(sut.DecodeCiphertext("ch   ie   pr", 3), Is.EqualTo("cipher"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02075();
        Assert.That(sut.DecodeCiphertext("iveo    eed   l te   olc", 4), Is.EqualTo("i love leetcode"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02075();
        Assert.That(sut.DecodeCiphertext("coding", 1), Is.EqualTo("coding"));
    }
}
