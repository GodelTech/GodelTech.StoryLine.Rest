namespace GodelTech.StoryLine.Rest.Services.Resources
{
    internal interface IMethodDetailsFilter
    {
        bool IsTestMethod(StackFrame details);
    }
}