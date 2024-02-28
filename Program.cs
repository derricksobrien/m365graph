using System.CommandLine;

var provisionConnectionCommand = new Command("provision-connection", "Provisions external connection");
provisionConnectionCommand.SetHandler(ConnectionService.   ProvisionConnection);

var rootCommand = new RootCommand();
rootCommand.AddCommand(provisionConnectionCommand);


var loadContentCommand = new Command("load-content", "Loads content into the external connection");
loadContentCommand.SetHandler(ContentService.LoadContent);

rootCommand.AddCommand(loadContentCommand);

Environment.Exit(await rootCommand.InvokeAsync(args));
