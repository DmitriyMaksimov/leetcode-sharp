using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00917Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00917();
        sut.ReverseOnlyLetters("ab-cd").Should().Be("dc-ba");
    }

    [Test]
    public void T2()
    {
        var sut = new S00917();
        sut.ReverseOnlyLetters("a-bC-dEf-ghIj").Should().Be("j-Ih-gfE-dCba");
    }

    [Test]
    public void T3()
    {
        var sut = new S00917();
        sut.ReverseOnlyLetters("Test1ng-Leet=code-Q!").Should().Be("Qedo1ct-eeLg=ntse-T!");
    }
}