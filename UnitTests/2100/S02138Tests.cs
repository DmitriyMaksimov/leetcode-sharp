using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02138Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02138();
        Assert.That(sut.DivideString("abcdefghi", 3, 'x'), Is.EqualTo((string[]) ["abc", "def", "ghi"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02138();
        Assert.That(sut.DivideString("abcdefghij", 3, 'x'), Is.EqualTo((string[]) ["abc", "def", "ghi", "jxx"]));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S02138();
        Assert.That(sut.DivideString("ctoyjrwtngqwt", 8, 'n'), Is.EqualTo((string[]) ["ctoyjrwt", "ngqwtnnn"]));
    }
}
