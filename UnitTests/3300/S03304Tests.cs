using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03304Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03304();
        sut.KthCharacter(5).Should().Be('b');
    }

    [Test]
    public void T2()
    {
        var sut = new S03304();
        sut.KthCharacter(10).Should().Be('c');
    }
}