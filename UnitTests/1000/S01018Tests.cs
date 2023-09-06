using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01018Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01018();
        sut.PrefixesDivBy5(new[] {0, 1, 1}).Should().Equal(true, false, false);
    }

    [Test]
    public void T2()
    {
        var sut = new S01018();
        sut.PrefixesDivBy5(new[] {1, 1, 1}).Should().Equal(false, false, false);
    }
}