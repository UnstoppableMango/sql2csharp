using UnMango.Ux.Plugins.Skeleton;

return Skel.PluginMain(UxFuncs.Default with
{
	Execute = (cmdArgs, cancellationToken) =>
	{
		System.Console.WriteLine("Got here");
		return ValueTask.CompletedTask;
	},
});
