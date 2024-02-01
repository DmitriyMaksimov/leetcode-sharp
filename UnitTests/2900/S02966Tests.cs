using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02966Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02966();
        sut.DivideArray([1, 3, 4, 8, 7, 9, 3, 5, 1], 2).Should().BeEquivalentTo([(int[]) [1, 1, 3], [3, 4, 5], [7, 8, 9]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S02966();
        sut.DivideArray([1, 3, 3, 2, 7, 3], 3).Should().BeEmpty();
    }
}