using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00779Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00779();
        sut.KthGrammar(1, 1).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S00779();
        sut.KthGrammar(2, 1).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00779();
        sut.KthGrammar(2, 2).Should().Be(1);
    }
}