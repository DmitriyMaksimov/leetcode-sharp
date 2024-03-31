using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02186Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02186();
        sut.MinSteps("leetcode", "coats").Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S02186();
        sut.MinSteps("night", "thing").Should().Be(0);
    }
}