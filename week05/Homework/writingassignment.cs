public class WritingAssignment : Assignment
{
    string title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        this.title = title;
    }

    public string GetWritingInformation()
    {
        return title + " by " + studentName;
    }
}
