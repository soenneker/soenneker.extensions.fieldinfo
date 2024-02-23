using Soenneker.Extensions.FieldInfo.Tests.Dtos;
using FluentAssertions;
using Xunit;

namespace Soenneker.Extensions.FieldInfo.Tests;

public class FieldInfoExtensionTests
{
    [Fact]
    public void IsConstant_should_be_true()
    {
        System.Reflection.FieldInfo? type = typeof(TestType).GetField("TestField1");

        type!.IsConstant().Should().BeTrue();
    }

    [Fact]
    public void IsConstant_should_be_false_readonly()
    {
        System.Reflection.FieldInfo? type = typeof(TestType).GetField("TestField2");

        type!.IsConstant().Should().BeFalse();
    }

    [Fact]
    public void IsConstant_should_be_false_static_readonly()
    {
        System.Reflection.FieldInfo? type = typeof(TestType).GetField("TestField3");

        type!.IsConstant().Should().BeFalse();
    }

    [Fact]
    public void IsConstant_should_be_false()
    {
        System.Reflection.FieldInfo? type = typeof(TestType).GetField("TestField4");

        type!.IsConstant().Should().BeFalse();
    }
}