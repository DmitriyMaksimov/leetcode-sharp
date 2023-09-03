using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00806Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00806();
        sut.NumberOfLines(new[] {10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10}, "abcdefghijklmnopqrstuvwxyz").Should()
            .Equal(3, 60);
    }

    [Test]
    public void T3()
    {
        var sut = new S00806();
        sut.NumberOfLines(new[] {4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10}, "bbbcccdddaaa").Should().Equal(2, 4);
    }
}