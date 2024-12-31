// https://www.youtube.com/watch?v=1g79ZbeEeL8 - video for EF Core Power Tools
// Disaplays data from NNs Azure NDP
// Display all agnet no. and his license no.

using EFTools.Models;


using var db = new DBContext();

var agentList = db.Agents.OrderBy(c => c.PartyKey).ToList();

//

foreach (var agent in agentList)
{
    Console.WriteLine($"{agent.AgentId} : {agent.LicenseNbr}");
}





