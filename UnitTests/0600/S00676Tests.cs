using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00676Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00676.MagicDictionary();
        sut.BuildDict(["hello", "leetcode"]);
        sut.Search("hello").Should().BeFalse();
        sut.Search("hhllo").Should().BeTrue();
        sut.Search("hell").Should().BeFalse();
        sut.Search("leetcoded").Should().BeFalse();
    }
}
