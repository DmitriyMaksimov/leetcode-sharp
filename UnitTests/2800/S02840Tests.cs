using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02840Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02840();
        sut.CheckStrings("abcdba", "cabdab").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02840();
        sut.CheckStrings("abe", "bea").Should().BeFalse();
    }
}
