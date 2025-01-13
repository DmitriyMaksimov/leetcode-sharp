using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02588Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02588();
        sut.BeautifulSubarrays([4, 3, 1, 2, 4]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02588();
        sut.BeautifulSubarrays([1, 10, 4]).Should().Be(0);
    }
}
