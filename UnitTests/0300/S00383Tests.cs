using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00383Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00383();
        sut.CanConstruct("a", "b").Should().BeFalse();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00383();
        sut.CanConstruct("aa", "ab").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00383();
        sut.CanConstruct("aa", "aab").Should().BeTrue();
    }
}