using BlazorSampleApp.Components.Model;

namespace BlazorSampleApp.Components.Objects
{

    public interface IQuestionFactory
    {
        Question Create(string questionText, int score);
    }

    public class ChoiceQuestionFactory : IQuestionFactory
    {
        public Question Create(string questionText, int score)
        {
            return new ChoiceQuestion
            {
                Text = questionText,
                Score = score
            };
        }
    }

    public class TextQuestionFactory : IQuestionFactory
    {
        public Question Create(string questionText, int score)
        {
            return new TextQuestion
            {
                Text = questionText,
                Score = score
            };
        }
    }
}
