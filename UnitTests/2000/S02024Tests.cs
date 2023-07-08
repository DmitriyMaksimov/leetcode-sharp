using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02024Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02024();
        sut.MaxConsecutiveAnswers("TTFF", 2).Should().Be(4);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02024();
        sut.MaxConsecutiveAnswers("TFFT", 1).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02024();
        sut.MaxConsecutiveAnswers("TTFTTFTT", 1).Should().Be(5);
    }
}