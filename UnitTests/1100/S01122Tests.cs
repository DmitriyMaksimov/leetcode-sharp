using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01122Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01122();
        sut.RelativeSortArray(new[] {2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19}, new[] {2, 1, 4, 3, 9, 6}).Should()
            .Equal(2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19);
    }

    [Test]
    public void T2()
    {
        var sut = new S01122();
        sut.RelativeSortArray(new[] {28, 6, 22, 8, 44, 17}, new[] {22, 28, 8, 6}).Should().Equal(22, 28, 8, 6, 17, 44);
    }
}