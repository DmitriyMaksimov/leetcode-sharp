using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00399Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00399();
        sut.CalcEquation(
                new List<IList<string>> {new[] {"a", "b"}, new[] {"b", "c"}},
                new[] {2.0, 3.0},
                new List<IList<string>> {new[] {"a", "c"}, new[] {"b", "a"}, new[] {"a", "e"}, new[] {"a", "a"}, new[] {"x", "x"}})
            .Should().Equal(6.00000, 0.50000, -1.00000, 1.00000, -1.00000);
    }

    [Test]
    public void T2()
    {
        var sut = new S00399();
        sut.CalcEquation(
                new List<IList<string>> {new[] {"a", "b"}, new[] {"b", "c"}, new[] {"bc", "cd"}},
                new[] {1.5, 2.5, 5.0},
                new List<IList<string>> {new[] {"a", "c"}, new[] {"c", "b"}, new[] {"bc", "cd"}, new[] {"cd", "bc"}})
            .Should().Equal(3.75, 0.4, 5.0, 0.2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00399();
        sut.CalcEquation(
                new List<IList<string>> {new[] {"a", "b"}},
                new[] {0.5},
                new List<IList<string>> {new[] {"a", "b"}, new[] {"b", "a"}, new[] {"a", "c"}, new[] {"x", "y"}})
            .Should().Equal(0.5, 2.0, -1, -1);
    }
}