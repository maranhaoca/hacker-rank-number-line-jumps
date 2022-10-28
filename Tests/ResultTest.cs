using System;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        int x1 = 2;
        int v1 = 1;
        int x2 = 1;
        int v2 = 2;

        string expected = "YES";
        string actual = Result.kangaroo(x1, v1, x2, v2);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        int x1 = 0;
        int v1 = 3;
        int x2 = 4;
        int v2 = 2;

        string expected = "YES";
        string actual = Result.kangaroo(x1, v1, x2, v2);

        Assert.Equal(expected, actual);
    }
}