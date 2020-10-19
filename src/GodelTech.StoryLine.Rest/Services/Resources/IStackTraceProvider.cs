namespace GodelTech.StoryLine.Rest.Services.Resources
{
    internal interface IStackTraceProvider
    {
        StackFrame[] GetStack();
    }
}