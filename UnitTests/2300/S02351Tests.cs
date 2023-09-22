using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02351Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02351();
        sut.RepeatedCharacter("abccbaacz").Should().Be('c');
    }

    [Test]
    public void T2()
    {
        var sut = new S02351();
        sut.RepeatedCharacter("abcdd").Should().Be('d');
    }
}