using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01238Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01238();
        sut.CircularPermutation(2, 3).Should().Equal(3, 2, 0, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01238();
        sut.CircularPermutation(3, 2).Should().Equal(2, 6, 7, 5, 4, 0, 1, 3);
    }
}
