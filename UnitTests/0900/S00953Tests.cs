using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00953Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00953();
        sut.IsAlienSorted(new[] {"hello", "leetcode"}, "hlabcdefgijkmnopqrstuvwxyz").Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00953();
        sut.IsAlienSorted(new[] {"word","world","row"}, "worldabcefghijkmnpqstuvxyz").Should().BeFalse();
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00953();
        sut.IsAlienSorted(new[] {"apple","app"}, "abcdefghijklmnopqrstuvwxyz").Should().BeFalse();
    }
}