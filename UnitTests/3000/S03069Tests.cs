using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03069Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03069();
        sut.ResultArray([2, 1, 3]).Should().Equal(2, 3, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03069();
        sut.ResultArray([5, 4, 3, 8]).Should().Equal(5, 3, 4, 8);
    }
}