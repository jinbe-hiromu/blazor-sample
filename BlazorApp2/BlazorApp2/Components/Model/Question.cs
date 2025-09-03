namespace BlazorApp1.Components.Model
{
    public abstract class Question
    {
        public string Text { get; set; } = string.Empty;
        public int Score { get; set; } = 0;
        public abstract QuestionType Type { get; set; }
    }

    public class TextQuestion : Question
    {
        public string CorrectText { get; set; } = string.Empty;
        public override QuestionType Type { get; set; } = QuestionType.Text;
    }

    public class ChoiceQuestion : Question
    {
        public List<string> Choices { get; set; } = new();
        public override QuestionType Type { get; set; } = QuestionType.Choice;
        public int CorrectIndex { get; set; } = -1;
    }
}
