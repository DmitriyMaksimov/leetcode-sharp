using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00135Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00135();
        sut.Candy(new[] {1, 0, 2}).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S00135();
        sut.Candy(new[] {1, 2, 2}).Should().Be(4);
    }
}