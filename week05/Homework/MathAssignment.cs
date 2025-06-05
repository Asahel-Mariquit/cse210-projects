public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    public MathAssignment(string studentName, string topic, string textbookSelection, string problem) : base(studentName, topic)
    {
        _textbookSection = textbookSelection;
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problem}";
    }
}