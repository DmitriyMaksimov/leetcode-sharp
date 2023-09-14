using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02138Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02138();
        sut.DivideString("abcdefghi", 3, 'x').Should().Equal("abc", "def", "ghi");
    }

    [Test]
    public void T2()
    {
        var sut = new S02138();
        sut.DivideString("abcdefghij", 3, 'x').Should().Equal("abc", "def", "ghi", "jxx");
    }
    
    [Test]
    public void T3()
    {
        var sut = new S02138();
        sut.DivideString("ctoyjrwtngqwt", 8, 'n').Should().Equal("ctoyjrwt", "ngqwtnnn");
    }
}