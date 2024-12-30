using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02013Tests
{
    [Test]
    public void T1()
    {
        var detectSquares = new S02013.DetectSquares();
        detectSquares.Add([3, 10]);
        detectSquares.Add([11, 2]);
        detectSquares.Add([3, 2]);
        detectSquares.Count([11, 10]).Should().Be(1); // return 1
        detectSquares.Count([14, 8]).Should().Be(0); // return 0. The query point cannot form a square with any points in the data structure.
        detectSquares.Add([11, 2]); // Adding duplicate points is allowed.
        detectSquares.Count([11, 10]).Should().Be(2); // return 2
    }
}
