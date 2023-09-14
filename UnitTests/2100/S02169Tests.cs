using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02169Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02169();
        sut.CountOperations(1, 3).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02169();
        sut.CountOperations(10, 10).Should().Be(1);
    }
}