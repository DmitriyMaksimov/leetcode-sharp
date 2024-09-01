using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02640Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02640();
        sut.FindPrefixScore([2, 3, 7, 5, 10]).Should().Equal(4, 10, 24, 36, 56);
    }

    [Test]
    public void T2()
    {
        var sut = new S02640();
        sut.FindPrefixScore([1, 1, 2, 4, 8, 16]).Should().Equal(2, 4, 8, 16, 32, 64);
    }
}
