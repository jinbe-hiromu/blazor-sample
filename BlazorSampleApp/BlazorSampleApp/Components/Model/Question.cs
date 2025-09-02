namespace BlazorSampleApp.Components.Model
{
    // モデル
    public enum QuestionType { Choice, Text }

    public class Question
    {
        public string Text { get; set; } = "";
        public int Score { get; set; } = 10;
        public QuestionType Type { get; set; } = QuestionType.Text;
        public List<string> Choices { get; set; } = new();
        public int CorrectIndex { get; set; } = -1; // 選択式の正解インデックス
        public string? CorrectText { get; set; }    // 記述式の正解
    }
}
