using Cake.Frosting;

[TaskName("Default")]
[IsDependentOn(typeof(BinderateTask))]
public class DefaultTask : FrostingTask
{
}
