using SqlParser;

namespace UnMango.Sql2Csharp;

public static class Plugin
{
	public static ValueTask<int> ExecuteAsync(IReadOnlyList<string> args, CancellationToken cancellationToken = default)
	{
		var parser = new SqlQueryParser();
		var seq = parser.Parse(args[0]);

		return new(0);
	}
}
