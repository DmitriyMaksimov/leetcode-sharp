using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00049Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00049();
        sut.GroupAnagrams(new[] {"eat", "tea", "tan", "ate", "nat", "bat"}).Should().BeEquivalentTo(new[]
        {
            new List<string> {"bat"},
            new List<string> {"nat", "tan"}, new List<string> {"ate", "eat", "tea"}
        });
    }

    [Test]
    public void T2()
    {
        var sut = new S00049();
        sut.GroupAnagrams(new[] {""}).Should().BeEquivalentTo(new[] {new List<string> {""}});
    }

    [Test]
    public void T3()
    {
        var sut = new S00049();
        sut.GroupAnagrams(new[] {"a"}).Should().BeEquivalentTo(new[] {new List<string> {"a"}});
    }
}