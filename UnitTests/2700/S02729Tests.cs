using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02729Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02729();
        sut.IsFascinating(192).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02729();
        sut.IsFascinating(100).Should().BeFalse();
    }
}