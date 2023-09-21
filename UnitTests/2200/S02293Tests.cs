using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02293Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02293();
        sut.MinMaxGame(new[] {1, 3, 5, 2, 4, 8, 2, 2}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02293();
        sut.MinMaxGame(new[] {3}).Should().Be(3);
    }
}