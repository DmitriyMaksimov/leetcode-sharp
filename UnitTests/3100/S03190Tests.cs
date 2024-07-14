using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03190Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03190();
        sut.MinimumOperations([1, 2, 3, 4]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03190();
        sut.MinimumOperations([3, 6, 9]).Should().Be(0);
    }
}