using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00932Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00932();
        sut.BeautifulArray(4).Should().Equal(1, 3, 2, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00932();
        sut.BeautifulArray(5).Should().Equal(1, 5, 3, 2, 4);
    }
}
