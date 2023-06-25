using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00657Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00657();
        sut.JudgeCircle("UD").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00657();
        sut.JudgeCircle("LL").Should().BeFalse();
    }
}