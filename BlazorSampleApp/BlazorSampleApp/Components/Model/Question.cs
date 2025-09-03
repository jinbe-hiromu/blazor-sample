namespace BlazorSampleApp.Components.Model
{
    public enum QuestionType { Choice, Text }

    // 共通部分
    public abstract class Question
    {
        public string Text { get; set; } = string.Empty;
        public int Score { get; set; } = 10;
        public abstract QuestionType Type { get; }
    }

    // 選択式
    public class ChoiceQuestion : Question
    {
        public override QuestionType Type => QuestionType.Choice;
        public List<string> Choices { get; set; } = new();
        public int CorrectIndex { get; set; } = -1;
    }

    // 記述式
    public class TextQuestion : Question
    {
        public override QuestionType Type => QuestionType.Text;
        public string CorrectText { get; set; } = string.Empty;
    }
}
