using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01239Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01239();
        sut.MaxLength(new[] { "un","iq","ue"}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01239();
        sut.MaxLength(new[] {"cha","r","act","ers" }).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S01239();
        sut.MaxLength(new[] { "abcdefghijklmnopqrstuvwxyz"}).Should().Be(26);
    }
}