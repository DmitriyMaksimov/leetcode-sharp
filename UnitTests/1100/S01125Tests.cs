using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01125Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01125();
        sut.SmallestSufficientTeam(
            new[] {"java", "nodejs", "reactjs"},
            new List<IList<string>>
            {
                new List<string> {"java"}, new List<string> {"nodejs"}, new List<string> {"nodejs", "reactjs"}
            }).Should().Equal(0, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01125();
        sut.SmallestSufficientTeam(
            new[] {"algorithms", "math", "java", "reactjs", "csharp", "aws"},
            new List<IList<string>>
            {
                new List<string> {"algorithms", "math", "java"},
                new List<string> {"algorithms", "math", "reactjs"},
                new List<string> {"java", "csharp", "aws"},
                new List<string> {"reactjs", "csharp"},
                new List<string> {"csharp", "math"},
                new List<string> {"aws", "java"},
            }).Should().Equal(1, 2);
    }
}