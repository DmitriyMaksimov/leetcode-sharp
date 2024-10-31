using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02109Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02109();
        sut.AddSpaces("LeetcodeHelpsMeLearn", [8, 13, 15]).Should().Be("Leetcode Helps Me Learn");
    }

    [Test]
    public void T2()
    {
        var sut = new S02109();
        sut.AddSpaces("icodeinpython", [1, 5, 7, 9]).Should().Be("i code in py thon");
    }

    [Test]
    public void T3()
    {
        var sut = new S02109();
        sut.AddSpaces("spacing", [0, 1, 2, 3, 4, 5, 6]).Should().Be(" s p a c i n g");
    }
}
