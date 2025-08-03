using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01125Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01125();
        Assert.That(sut.SmallestSufficientTeam(
            ["java", "nodejs", "reactjs"],
            new List<IList<string>>
            {
                new List<string> {"java"}, new List<string> {"nodejs"}, new List<string> {"nodejs", "reactjs"}
            }), Is.EqualTo((int[]) [0, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01125();
        Assert.That(sut.SmallestSufficientTeam(
            ["algorithms", "math", "java", "reactjs", "csharp", "aws"],
            new List<IList<string>>
            {
                new List<string> {"algorithms", "math", "java"},
                new List<string> {"algorithms", "math", "reactjs"},
                new List<string> {"java", "csharp", "aws"},
                new List<string> {"reactjs", "csharp"},
                new List<string> {"csharp", "math"},
                new List<string> {"aws", "java"},
            }), Is.EqualTo((int[]) [1, 2]));
    }
}