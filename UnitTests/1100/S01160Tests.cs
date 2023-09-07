using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01160Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01160();
        sut.CountCharacters(new[] {"cat", "bt", "hat", "tree"}, "atach").Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01160();
        sut.CountCharacters(new[] {"hello", "world", "leetcode"}, "welldonehoneyr").Should().Be(10);
    }
}