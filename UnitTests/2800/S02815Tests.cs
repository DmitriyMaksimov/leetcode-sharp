using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02815Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02815();
        sut.MaxSum(new[] {51, 71, 17, 24, 42}).Should().Be(88);
    }

    [Test]
    public void T2()
    {
        var sut = new S02815();
        sut.MaxSum(new[] {1, 2, 3, 4}).Should().Be(-1);
    }
}