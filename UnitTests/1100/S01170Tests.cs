using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01170Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01170();
        sut.NumSmallerByFrequency(["cbd"], ["zaaaz"]).Should().Equal(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01170();
        sut.NumSmallerByFrequency(["bbb", "cc"], ["a", "aa", "aaa", "aaaa"]).Should().Equal(1, 2);
    }
}
