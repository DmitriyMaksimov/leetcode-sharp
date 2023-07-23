using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02553Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02553();
        sut.SeparateDigits(new[] {13, 25, 83, 77}).Should().Equal(1, 3, 2, 5, 8, 3, 7, 7);
    }

    [Test]
    public void T2()
    {
        var sut = new S02553();
        sut.SeparateDigits(new[] {7, 1, 3, 9}).Should().Equal(7, 1, 3, 9);
    }
}