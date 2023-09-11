using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01668Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01668();
        sut.MaxRepeating("ababc", "ab").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01668();
        sut.MaxRepeating("ababc", "ba").Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01668();
        sut.MaxRepeating("ababc", "ac").Should().Be(0);
    }
}