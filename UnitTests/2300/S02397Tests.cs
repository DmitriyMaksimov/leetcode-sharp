using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02397Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02397();
        sut.MaximumRows([[0, 0, 0], [1, 0, 1], [0, 1, 1], [0, 0, 1]], 2).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02397();
        sut.MaximumRows([[1], [0]], 1).Should().Be(2);
    }
}
