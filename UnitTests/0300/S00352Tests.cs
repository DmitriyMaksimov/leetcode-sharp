using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00352Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00352();
        sut.AddNum(1);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([new[] {1, 1}]));
        sut.AddNum(3);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[1, 1], new[] {3, 3}]));
        sut.AddNum(7);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[1, 1], [3, 3], new[] {7, 7}]));
        sut.AddNum(2);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[1, 3], new[] {7, 7}]));
        sut.AddNum(6);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[1, 3], new[] {6, 7}]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00352();
        sut.AddNum(1);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([new[] {1, 1}]));
        sut.AddNum(9);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[1, 1], new[] {9, 9}]));
        sut.AddNum(2);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[1, 2], new[] {9, 9}]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00352();
        sut.AddNum(6);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([new[] {6, 6}]));
        sut.AddNum(6);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([new[] {6, 6}]));
        sut.AddNum(0);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[0, 0], new[] {6, 6}]));
        sut.AddNum(4);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[0, 0], [4, 4], new[] {6, 6}]));
        sut.AddNum(8);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[0, 0], [4, 4], [6, 6], new[] {8, 8}]));
        sut.AddNum(7);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[0, 0], [4, 4], new[] {6, 8}]));
        sut.AddNum(6);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[0, 0], [4, 4], new[] {6, 8}]));
        sut.AddNum(4);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[0, 0], [4, 4], new[] {6, 8}]));
        sut.AddNum(7);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[0, 0], [4, 4], new[] {6, 8}]));
        sut.AddNum(5);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([[0, 0], new[] {4, 8}]));
    }

    [Test]
    public void T4()
    {
        var sut = new S00352();
        sut.AddNum(49);
        sut.AddNum(97);
        sut.AddNum(53);
        sut.AddNum(5);
        sut.AddNum(33);
        sut.AddNum(65);
        sut.AddNum(62);
        sut.AddNum(51);
        sut.AddNum(100);
        sut.AddNum(38);
        sut.AddNum(61);
        sut.AddNum(45);
        sut.AddNum(74);
        sut.AddNum(27);
        sut.AddNum(64);
        sut.AddNum(17);
        sut.AddNum(36);
        sut.AddNum(17);
        sut.AddNum(96);
        sut.AddNum(12);
        sut.AddNum(79);
        sut.AddNum(32);
        sut.AddNum(68);
        sut.AddNum(90);
        sut.AddNum(77);
        sut.AddNum(18);
        sut.AddNum(39);
        sut.AddNum(12);
        sut.AddNum(93);
        sut.AddNum(9);
        sut.AddNum(87);
        sut.AddNum(42);
        sut.AddNum(60);
        sut.AddNum(71);
        sut.AddNum(12);
        sut.AddNum(45);
        sut.AddNum(55);
        sut.AddNum(40);
        sut.AddNum(78);
        sut.AddNum(81);
        sut.AddNum(26);
        sut.AddNum(70);
        sut.AddNum(61);
        sut.AddNum(56);
        sut.AddNum(66);
        sut.AddNum(33);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([
            [5, 5], [9, 9], [12, 12], [17, 18], [26, 27], [32, 33], [36, 36], [38, 40], [42, 42],
            [45, 45], [49, 49], [51, 51], [53, 53], [55, 56], [60, 62], [64, 66], [68, 68], [70, 71],
            [74, 74], [77, 79], [81, 81], [87, 87], [90, 90], [93, 93], [96, 97], new[] {100, 100}
        ]));
        sut.AddNum(7);
        sut.AddNum(70);
        sut.AddNum(1);
        sut.AddNum(11);
        sut.AddNum(92);
        sut.AddNum(51);
        sut.AddNum(90);
        sut.AddNum(100);
        sut.AddNum(85);
        sut.AddNum(80);
        sut.AddNum(0);
        sut.AddNum(78);
        sut.AddNum(63);
        sut.AddNum(42);
        sut.AddNum(31);
        sut.AddNum(93);
        sut.AddNum(41);
        sut.AddNum(90);
        sut.AddNum(8);
        sut.AddNum(24);
        sut.AddNum(72);
        sut.AddNum(28);
        sut.AddNum(30);
        sut.AddNum(18);
        sut.AddNum(69);
        sut.AddNum(57);
        sut.AddNum(11);
        sut.AddNum(10);
        sut.AddNum(40);
        sut.AddNum(65);
        sut.AddNum(62);
        sut.AddNum(13);
        sut.AddNum(38);
        sut.AddNum(70);
        sut.AddNum(37);
        sut.AddNum(90);
        sut.AddNum(15);
        sut.AddNum(70);
        sut.AddNum(42);
        sut.AddNum(69);
        sut.AddNum(26);
        sut.AddNum(77);
        sut.AddNum(70);
        sut.AddNum(75);
        sut.AddNum(36);
        sut.AddNum(56);
        sut.AddNum(11);
        sut.AddNum(76);
        sut.AddNum(49);
        sut.AddNum(40);
        sut.AddNum(73);
        sut.AddNum(30);
        sut.AddNum(37);
        sut.AddNum(23);
        Assert.That(sut.GetIntervals(), Is.EquivalentTo([
            [0, 1], [5, 5], [7, 13], [15, 15], [17, 18], [23, 24], [26, 28], [30, 33], [36, 42], [45, 45],
            [49, 49], [51, 51], [53, 53], [55, 57], [60, 66], [68, 81], [85, 85], [87, 87], [90, 90], [92, 93],
            [96, 97], new[] {100, 100}
        ]));
    }
}