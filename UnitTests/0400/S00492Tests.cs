using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00492Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00492();
        sut.ConstructRectangle(4).Should().Equal(2, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00492();
        sut.ConstructRectangle(37).Should().Equal(37, 1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00492();
        sut.ConstructRectangle(122122).Should().Equal(427, 286);
    }
}