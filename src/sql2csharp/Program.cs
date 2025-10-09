using UnMango.Sql2Csharp;
using UnMango.Ux.Plugins.Skeleton;

return Skel.PluginMain(UxFuncs.Default with
{
	Execute = async (cmdArgs, cancellationToken)
		=> await Plugin.ExecuteAsync(cmdArgs.Args, cancellationToken),
});
