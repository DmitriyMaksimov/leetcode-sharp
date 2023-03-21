using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00118Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00118();
        var list = sut.Generate(5);
        list.Should().HaveCount(5);
        list[0].Should().Equal(1);
        list[1].Should().Equal(1, 1);
        list[2].Should().Equal(1, 2, 1);
        list[3].Should().Equal(1, 3, 3, 1);
        list[4].Should().Equal(1, 4, 6, 4, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00118();
        var list = sut.Generate(1);
        list.Should().HaveCount(1);
        list[0].Should().Equal(1);
    }
}