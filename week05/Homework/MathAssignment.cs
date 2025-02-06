public class MathAssignment : Assignment
{
    string section;
    string problems;

    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        this.section = section;
        this.problems = problems;
    }

    public string GetHomeworkList()
    {
        return "Section " + section + " Problems " + problems;
    }
}
