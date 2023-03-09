using AdapterTranspiler;
using ConsoulLibrary;
using Microsoft.Extensions.Logging;
using MtconnectTranspiler;

internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length == 0) throw new ArgumentNullException(nameof(args), "Missing projectPath argument");

        string projectPath = args[0];
        if (!Directory.Exists(projectPath))
        {
            Consoul.Write("Creating project path: " + projectPath);
            Directory.CreateDirectory(projectPath);
        }

        var logFactory = LoggerFactory.Create((o) => o.AddConsoulLogger());
        var dispatchLogger = logFactory.CreateLogger<TranspilerDispatcher>();
        var transpilerLogger = logFactory.CreateLogger<Transpiler>();


        // NOTE: The GitHubRelease can be a reference to a specific tag referring to the version in which to download.
        TranspilerDispatcherOptions dispatchOptions = null;
        if (args.Length > 1)
        {
            if (!File.Exists(args[1])) throw new FileNotFoundException(args[1]);

            dispatchOptions = new FromFileOptions() { Filepath = args[1] };
            Consoul.Write("Dispatching from file: " + args[1]);
        }
        else
        {
            dispatchOptions = new FromGitHubOptions() { GitHubRelease = "latest" };
            Consoul.Write("Dispatching from GitHub's latest release");
        }

        using (var tokenSource = new CancellationTokenSource())
        using (var dispatcher = new TranspilerDispatcher(dispatchOptions, dispatchLogger))
        {
            dispatcher.AddSink(new Transpiler(projectPath, transpilerLogger));

            Consoul.Write("Beginning deserialization and dispatching");
            var task = Task.Run(() => dispatcher.TranspileAsync(tokenSource.Token));

#if DEBUG
            task = task.ContinueWith((t) => tokenSource.Cancel());
            Consoul.Wait(cancellationToken: tokenSource.Token);
#else
            task.Wait();
#endif

            if (task.IsCompletedSuccessfully)
            {
                Consoul.Write("Done!", ConsoleColor.Green);

                Environment.Exit(0);
            }
            else
            {
                Consoul.Write("Cancelled", ConsoleColor.Red);
                Environment.Exit(1);
            }

        }
    }
}