using BlazorApp1.Components.Model;

namespace BlazorApp1.Components.Logic
{
    public class QuestionManager
    {

        public List<Question> Questions { get; set; } = new();

        public event Action? OnChange;

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
            NotifyStateChanged();
        }

        public void RemoveQuestion(Question question)
        {
            Questions.Remove(question);
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
