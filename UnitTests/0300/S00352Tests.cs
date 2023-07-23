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
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {1, 1}});
        sut.AddNum(3);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {1, 1}, new[] {3, 3}});
        sut.AddNum(7);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {1, 1}, new[] {3, 3}, new[] {7, 7}});
        sut.AddNum(2);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {1, 3}, new[] {7, 7}});
        sut.AddNum(6);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {1, 3}, new[] {6, 7}});
    }

    [Test]
    public void T2()
    {
        var sut = new S00352();
        sut.AddNum(1);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {1, 1}});
        sut.AddNum(9);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {1, 1}, new[] {9, 9}});
        sut.AddNum(2);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {1, 2}, new[] {9, 9}});
    }

    [Test]
    public void T3()
    {
        var sut = new S00352();
        sut.AddNum(6);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {6, 6}});
        sut.AddNum(6);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {6, 6}});
        sut.AddNum(0);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {0, 0}, new[] {6, 6}});
        sut.AddNum(4);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {0, 0}, new[] {4, 4}, new[] {6, 6}});
        sut.AddNum(8);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {0, 0}, new[] {4, 4}, new[] {6, 6}, new[] {8, 8}});
        sut.AddNum(7);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {0, 0}, new[] {4, 4}, new[] {6, 8}});
        sut.AddNum(6);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {0, 0}, new[] {4, 4}, new[] {6, 8}});
        sut.AddNum(4);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {0, 0}, new[] {4, 4}, new[] {6, 8}});
        sut.AddNum(7);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {0, 0}, new[] {4, 4}, new[] {6, 8}});
        sut.AddNum(5);
        sut.GetIntervals().Should().BeEquivalentTo(new[] {new[] {0, 0}, new[] {4, 8}});
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
        sut.GetIntervals().Should().BeEquivalentTo(new[]
        {
            new[] {5, 5}, new[] {9, 9}, new[] {12, 12}, new[] {17, 18}, new[] {26, 27}, new[] {32, 33}, new[] {36, 36}, new[] {38, 40}, new[] {42, 42},
            new[] {45, 45}, new[] {49, 49}, new[] {51, 51}, new[] {53, 53}, new[] {55, 56}, new[] {60, 62}, new[] {64, 66}, new[] {68, 68}, new[] {70, 71},
            new[] {74, 74}, new[] {77, 79}, new[] {81, 81}, new[] {87, 87}, new[] {90, 90}, new[] {93, 93}, new[] {96, 97}, new[] {100, 100}
        });
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
        sut.GetIntervals().Should().BeEquivalentTo(new[]
        {
            new[] {0, 1}, new[] {5, 5}, new[] {7, 13}, new[] {15, 15}, new[] {17, 18}, new[] {23, 24}, new[] {26, 28}, new[] {30, 33}, new[] {36, 42}, new[] {45, 45},
            new[] {49, 49}, new[] {51, 51}, new[] {53, 53}, new[] {55, 57}, new[] {60, 66}, new[] {68, 81}, new[] {85, 85}, new[] {87, 87}, new[] {90, 90}, new[] {92, 93},
            new[] {96, 97}, new[] {100, 100}
        });
    }
}