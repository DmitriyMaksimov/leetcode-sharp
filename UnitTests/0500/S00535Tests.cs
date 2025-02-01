using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00535Tests
{
    [TestCase("https://leetcode.com/problems/design-tinyurl")]
    public void T1(string url)
    {
        var sut = new S00535();
        var tiny = sut.encode(url);
        Assert.That(sut.decode(tiny), Is.EqualTo(url));
    }
}