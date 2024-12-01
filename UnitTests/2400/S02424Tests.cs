using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02424Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02424.LUPrefix(4);
        sut.Upload(3); // Upload video 3.
        sut.Longest().Should().Be(0); // Since video 1 has not been uploaded yet, there is no prefix. So, we return 0.
        sut.Upload(1); // Upload video 1.
        sut.Longest().Should().Be(1); // The prefix [1] is the longest uploaded prefix, so we return 1.
        sut.Upload(2); // Upload video 2.
        sut.Longest().Should().Be(3); // The prefix [1,2,3] is the longest uploaded prefix, so we return 3.
    }
}
