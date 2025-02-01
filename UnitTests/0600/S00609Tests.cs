using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00609Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00609();
        Assert.That(sut.FindDuplicate(["root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)", "root 4.txt(efgh)"]), Is.EquivalentTo((string[][]) [["root/a/2.txt", "root/c/d/4.txt", "root/4.txt"], ["root/a/1.txt", "root/c/3.txt"]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00609();
        Assert.That(sut.FindDuplicate(["root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)"]), Is.EquivalentTo((string[][]) [["root/a/2.txt", "root/c/d/4.txt"], ["root/a/1.txt", "root/c/3.txt"]]));
    }
}
