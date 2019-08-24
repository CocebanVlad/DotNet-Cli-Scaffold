using CliScaffold.Core;

namespace CliScaffold
{
    public class Program : CliProgram
    {
        public static void Main(string[] args)
        {
            var cli = new Program();
            cli.Run(args);
        }

        /// <summary>
        /// Register commands
        /// </summary>
        /// <param name="exec">Executor</param>
        protected override void RegisterCommands(CliExec exec)
        {
            exec.Register("detect", (p) =>
            {
            });
        }
    }
}
