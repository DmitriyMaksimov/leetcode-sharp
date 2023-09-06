using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01089Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01089();
        var arr = new[] {1, 0, 2, 3, 0, 4, 5, 0};
        sut.DuplicateZeros(arr);
        arr.Should().Equal(1, 0, 0, 2, 3, 0, 0, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01089();
        var arr = new[] {1, 2, 3};
        sut.DuplicateZeros(arr);
        arr.Should().Equal(1, 2, 3);
    }
}