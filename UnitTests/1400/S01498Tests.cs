using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01498Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01498();
        sut.NumSubseq(new[] {3,5,6,7}, 9).Should().Be(4);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01498();
        sut.NumSubseq(new[] {3,3,6,8}, 10).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S01498();
        sut.NumSubseq(new[] {2,3,3,4,6,7}, 12).Should().Be(61);
    }
}