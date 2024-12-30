using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00916Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00916();
        sut.WordSubsets(["amazon", "apple", "facebook", "google", "leetcode"], ["e", "o"]).Should().BeEquivalentTo("facebook", "google", "leetcode");
    }

    [Test]
    public void T2()
    {
        var sut = new S00916();
        sut.WordSubsets(["amazon", "apple", "facebook", "google", "leetcode"], ["l", "e"]).Should().BeEquivalentTo(["apple", "google", "leetcode"]);
    }
}
