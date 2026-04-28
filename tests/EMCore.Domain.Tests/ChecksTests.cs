using EMCore.Domain.Checks;
using Xunit;

namespace EMCore.Domain.Tests;

public class ChecksTests
{
    [Fact]
    public void CheckQuestion_QuestionType_ShouldDefault()
    {
        var question = new CheckQuestion
        {
            Id = Guid.NewGuid(),
            TenantId = Guid.NewGuid(),
            CheckSectionId = Guid.NewGuid(),
            Text = "Is the AED functional?",
            QuestionType = CheckQuestionType.PassFail,
            IsRequired = true
        };

        Assert.Equal(CheckQuestionType.PassFail, question.QuestionType);
        Assert.True(question.IsRequired);
    }

    [Theory]
    [InlineData(CheckQuestionType.PassFail)]
    [InlineData(CheckQuestionType.YesNo)]
    [InlineData(CheckQuestionType.NumericCount)]
    [InlineData(CheckQuestionType.Text)]
    public void CheckQuestionType_AllValues_AreValid(CheckQuestionType type)
    {
        Assert.True(Enum.IsDefined(type));
    }

    [Fact]
    public void CheckInstance_ShouldTrackCompletionStatus()
    {
        var instance = new CheckInstance
        {
            Id = Guid.NewGuid(),
            TenantId = Guid.NewGuid(),
            CheckTemplateId = Guid.NewGuid(),
            SubjectId = Guid.NewGuid(),
            PerformedByUserId = Guid.NewGuid()
        };

        Assert.Null(instance.CompletedAt);
        Assert.Null(instance.Passed);

        instance.CompletedAt = DateTimeOffset.UtcNow;
        instance.Passed = true;

        Assert.NotNull(instance.CompletedAt);
        Assert.True(instance.Passed);
    }
}
