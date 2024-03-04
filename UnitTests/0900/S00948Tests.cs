using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00948Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00948();
        sut.BagOfTokensScore([100], 50).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00948();
        sut.BagOfTokensScore([200, 100], 150).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00948();
        sut.BagOfTokensScore([100, 200, 300, 400], 200).Should().Be(2);
    }
}