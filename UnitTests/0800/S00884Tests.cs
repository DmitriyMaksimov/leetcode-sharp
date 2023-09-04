using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00884Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00884();
        sut.UncommonFromSentences("this apple is sweet", "this apple is sour").Should().Equal("sweet", "sour");
    }

    [Test]
    public void T2()
    {
        var sut = new S00884();
        sut.UncommonFromSentences("apple apple", "banana").Should().Equal("banana");
    }
}