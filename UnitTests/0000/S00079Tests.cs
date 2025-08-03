using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00079Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00079();
        Assert.That(sut.Exist([['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']], "ABCCED"), Is.True);
    }
}
