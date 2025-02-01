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
        Assert.That(matrix[0], Is.EqualTo((int[]) [1, 2, 3]));
        Assert.That(matrix[1], Is.EqualTo((int[]) [8, 9, 4]));
        Assert.That(matrix[2], Is.EqualTo((int[]) [7, 6, 5]));
    }
}