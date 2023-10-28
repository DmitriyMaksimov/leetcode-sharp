using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01220Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01220();
        sut.CountVowelPermutation(1).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01220();
        sut.CountVowelPermutation(2).Should().Be(10);
    }

    [Test]
    public void T3()
    {
        var sut = new S01220();
        sut.CountVowelPermutation(5).Should().Be(68);
    }
}