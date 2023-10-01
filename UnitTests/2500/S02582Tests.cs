using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02582Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02582();
        sut.PassThePillow(4, 5).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02582();
        sut.PassThePillow(3, 2).Should().Be(3);
    }
}