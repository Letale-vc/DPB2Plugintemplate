using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using Message = DreamPoeBot.Loki.Bot.Message;
using UserControl = System.Windows.Controls.UserControl;

namespace EmptyProject
{
    public class EmptyProject : IContent//NOTE: you can also manually inherit from IStartStopEvents if you need to override Start/Stop event handlers.
    {
        private static readonly ILog Log = Logger.GetLoggerInstanceForType();


        private EmptyProjectGui _gui;
        //NOTE: this is equivalent to _gui ?? (_gui = new EmptyProjectGui());
        //which is also equivalent to 
        //if (_gui == null)
        //{
        //	_gui = new EmptyProjectGui();
        //}
        //LINK: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
        public UserControl Control => _gui ??= new EmptyProjectGui();
        public JsonSettings Settings => EmptyProjectSettings.Instance;

        public MessageResult Message(Message message)
        {
            return MessageResult.Unprocessed;
        }

        /// <summary>
        /// author of this project
        /// </summary>
        public string Author => "me";

        /// <summary>
        /// Description of this project
        /// </summary>
        public string Description => "thing that does something";

        /// <summary>
        /// Name of this project
        /// </summary>
        public string Name => "EmptyProject";

        /// <summary>
        /// Version of this project
        /// </summary>
        public string Version => "0.0.0.1";

        public void Deinitialize()
        {
            Log.Info($"deinitializing {Name} - {Description} by {Author}, version {Version}");
        }

        public void Initialize()
        {
            Log.Info($"initializing {Name} - {Description} by {Author}, version {Version}");
        }

        public async Task<LogicResult> Logic(Logic logic)
        {
            return LogicResult.Unprovided;
        }
    }
}