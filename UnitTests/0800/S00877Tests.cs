using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00877Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00877();
        sut.StoneGame([5, 3, 4, 5]).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00877();
        sut.StoneGame([3, 7, 2, 3]).Should().BeTrue();
    }
}
