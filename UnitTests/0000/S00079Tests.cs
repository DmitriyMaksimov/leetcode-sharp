using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00079Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00079();
        sut.Exist(new[] {new[] {'A', 'B', 'C', 'E'}, new[] {'S', 'F', 'C', 'S'}, new[] {'A', 'D', 'E', 'E'}}, "ABCCED").Should().BeTrue();
    }
}