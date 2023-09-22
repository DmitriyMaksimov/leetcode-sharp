using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02357Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02357();
        sut.MinimumOperations(new[] {1, 5, 0, 3, 5}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02357();
        sut.MinimumOperations(new[] {0}).Should().Be(0);
    }
}