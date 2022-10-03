namespace Csharp.Tests
{
    public class GoalParserInterpretationTest
    {
        public string Interpret(string command)
        {
            return command.Replace("()", "o").Replace("(al)", "al");
        }
    }


}