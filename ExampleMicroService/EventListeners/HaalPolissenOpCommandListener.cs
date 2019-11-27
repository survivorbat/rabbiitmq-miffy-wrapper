using System;
using System.Linq;
using ExampleMicroService.Commands;
using ExampleMicroService.DAL;
using Minor.Miffy.MicroServices.Events;

namespace ExampleMicroService.EventListeners
{
    /// <summary>
    /// An example command listeners that listens for incoming commands.
    ///
    /// NOTE:
    /// The base framework was originally provided by an external entity
    /// and was not entirely suitable for my personal implementation
    /// of the assignment.
    ///
    /// For this reason, creating a new command listener class for each
    /// command listeners is quite excessive and this process will be changed in the feature
    /// </summary>
    [CommandListener("MVM.TestService.HaalPolissenOpQueue")]
    public class HaalPolissenOpCommandListener
    {
        /// <summary>
        /// Database context as an example
        /// </summary>
        private readonly PolisContext _context;

        /// <summary>
        /// Constructor with injected dependencies
        /// </summary>
        /// <param name="context">Database Context</param>
        public HaalPolissenOpCommandListener(PolisContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Receives a command, then returns a changed command
        /// </summary>
        /// <param name="command">Received command from a certain source</param>
        /// <returns>A new or modified command with new data</returns>
        public HaalPolissenOpCommand Handle(HaalPolissenOpCommand command)
        {
            command.Polisses = _context.Polissen.ToArray();
            return command;
        }
    }
}