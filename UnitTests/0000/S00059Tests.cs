using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00059Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00059();
        var matrix = sut.GenerateMatrix(3);
        matrix[0].Should().Equal(1, 2, 3);
        matrix[1].Should().Equal(8, 9, 4);
        matrix[2].Should().Equal(7, 6, 5);
    }
}