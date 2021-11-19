

using Kuiper.Services;

namespace Kuiper.Systems
{
    public class SaveCommand : CaptainBaseCommand
    {
        public SaveCommand(ICaptainService captainService, IGameTimeService gameTimeService) : base(captainService, gameTimeService)
        {
        }

        public override string Name => "save";

        public override void Execute(string[] args)
        {
            ConsoleWriter.Write("Saving game...", System.ConsoleColor.Red);
            _captainService.SaveGame();
            ConsoleWriter.Write("Game saved", System.ConsoleColor.Red);
        }
    }
} 