using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01078Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01078();
        sut.FindOcurrences("alice is a good girl she is a good student", "a", "good").Should().Equal("girl", "student");
    }

    [Test]
    public void T2()
    {
        var sut = new S01078();
        sut.FindOcurrences("we will we will rock you", "we", "will").Should().Equal("we", "rock");
    }
}