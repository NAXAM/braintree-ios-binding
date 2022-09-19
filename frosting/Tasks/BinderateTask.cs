using System.Threading.Tasks;
using Cake.Frosting;
using CocoaPods.Binderator;

[TaskName("binderate")]
public sealed class BinderateTask : AsyncFrostingTask<BuildContext>
{
    public override async Task RunAsync(BuildContext context)
	{
		context.ProjectModels = await Engine.BinderateAsync(context.ConfigPath, context.BasePath);
    }
}
