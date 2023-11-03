using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01441Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01441();
        sut.BuildArray(new[] {1, 3}, 3).Should().Equal("Push", "Push", "Pop", "Push");
    }

    [Test]
    public void T2()
    {
        var sut = new S01441();
        sut.BuildArray(new[] {1, 2, 3}, 3).Should().Equal("Push", "Push", "Push");
    }

    [Test]
    public void T3()
    {
        var sut = new S01441();
        sut.BuildArray(new[] {1, 2}, 4).Should().Equal("Push", "Push");
    }
}