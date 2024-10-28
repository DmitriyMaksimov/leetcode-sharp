using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00089Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00089();
        sut.GrayCode(2).Should().Equal(0, 1, 3, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00089();
        sut.GrayCode(1).Should().Equal(0, 1);
    }
}
