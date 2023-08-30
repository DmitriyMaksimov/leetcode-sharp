using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00504Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00504();
        sut.ConvertToBase7(100).Should().Be("202");
    }

    [Test]
    public void T2()
    {
        var sut = new S00504();
        sut.ConvertToBase7(-7).Should().Be("-10");
    }
}