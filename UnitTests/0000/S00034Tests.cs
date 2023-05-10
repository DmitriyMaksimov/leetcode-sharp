using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00034Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00034();
        sut.SearchRange(new[] {5, 7, 7, 8, 8, 10}, 8).Should().Equal(3, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00034();
        sut.SearchRange(new[] {5, 7, 7, 8, 8, 10}, 6).Should().Equal(-1, -1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00034();
        sut.SearchRange(Array.Empty<int>(), 0).Should().Equal(-1, -1);
    }

    [Test]
    public void T4()
    {
        var sut = new S00034();
        sut.SearchRange(new[] {2, 2}, 3).Should().Equal(-1, -1);
    }

    [Test]
    public void T5()
    {
        var sut = new S00034();
        sut.SearchRange(new[] {2, 2}, 2).Should().Equal(0, 1);
    }
}