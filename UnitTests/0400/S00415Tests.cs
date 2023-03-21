using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00415Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00415();
        sut.AddStrings("11", "123").Should().Be("134");
    }

    [Test]
    public void T2()
    {
        var sut = new S00415();
        sut.AddStrings("456", "77").Should().Be("533");
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00415();
        sut.AddStrings("0", "0").Should().Be("0");
    }
}