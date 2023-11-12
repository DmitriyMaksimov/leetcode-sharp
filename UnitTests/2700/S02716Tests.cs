using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02716Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02716();
        sut.MinimizedStringLength("aaabc").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02716();
        sut.MinimizedStringLength("cbbd").Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02716();
        sut.MinimizedStringLength("dddaaa").Should().Be(2);
    }
}