namespace EMCore.Domain.Checks;

using EMCore.Domain.Common;

public class CheckQuestion : TenantEntity
{
    public Guid CheckSectionId { get; set; }
    public CheckSection CheckSection { get; set; } = null!;

    public string Text { get; set; } = string.Empty;
    public CheckQuestionType QuestionType { get; set; }
    public bool IsRequired { get; set; } = true;
    public int DisplayOrder { get; set; }
}
