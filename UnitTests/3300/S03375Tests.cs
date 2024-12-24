using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03375Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03375();
        sut.MinOperations([5, 2, 5, 4, 5], 2).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S03375();
        sut.MinOperations([2, 1, 2], 2).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S03375();
        sut.MinOperations([9, 7, 5, 3], 1).Should().Be(4);
    }
}
