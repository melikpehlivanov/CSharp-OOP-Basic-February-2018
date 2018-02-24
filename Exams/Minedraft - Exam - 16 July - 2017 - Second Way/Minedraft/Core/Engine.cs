using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private DraftManager draftManager;

    public Engine()
    {
        this.isRunning = true;
        this.draftManager = new DraftManager();
    }

    public void Run()
    {
        while (this.isRunning)
        {
            string inputCommand = this.ReadInput();
            var commandParameters = this.ParseInput(inputCommand);
            this.DistributeCommand(commandParameters);
        }
    }

    private void DistributeCommand(List<string> commandParameters)
    {
        string command = commandParameters[0];
        commandParameters = commandParameters.Skip(1).ToList();

        switch (command)
        {
            case "RegisterHarvester":
                OutputWriter(this.draftManager.RegisterHarvester(commandParameters));
                break;
            case "RegisterProvider":
                OutputWriter(this.draftManager.RegisterProvider(commandParameters));
                break;
            case "Day":
                OutputWriter(this.draftManager.Day());
                break;
            case "Mode":
                OutputWriter(this.draftManager.Mode(commandParameters));
                break;
            case "Check":
                string status = this.draftManager.Check(commandParameters);
                this.OutputWriter(status);
                break;
            case "Shutdown":
                string record = this.draftManager.ShutDown();
                this.OutputWriter(record);
                this.isRunning = false;
                break;
        }
    }

    private void OutputWriter(string status) => Console.WriteLine(status);

    private List<string> ParseInput(string inputCommand)
    {
        return inputCommand.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    private string ReadInput()
    {
        return Console.ReadLine();
    }
}

