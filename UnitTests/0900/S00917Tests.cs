using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00917Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00917();
        Assert.That(sut.ReverseOnlyLetters("ab-cd"), Is.EqualTo("dc-ba"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00917();
        Assert.That(sut.ReverseOnlyLetters("a-bC-dEf-ghIj"), Is.EqualTo("j-Ih-gfE-dCba"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00917();
        Assert.That(sut.ReverseOnlyLetters("Test1ng-Leet=code-Q!"), Is.EqualTo("Qedo1ct-eeLg=ntse-T!"));
    }
}