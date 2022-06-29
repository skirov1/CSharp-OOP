using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            var privateSoldiers = new List<Private>();
            var repairs = new List<Repair>();
            while (true)
            {
                var info = Console.ReadLine().Split();
                if (info[0] == "End")
                {
                    break;
                }
                var soldierType = info[0];
                if (soldierType == "Private")
                {
                    var id = info[1];
                    var firstName = info[2];
                    var lastName = info[3];
                    var salary = decimal.Parse(info[4]);
                    var privateSoldier = new Private(id, firstName, lastName, salary);
                    privateSoldiers.Add(privateSoldier);
                    Console.WriteLine(privateSoldier.ToString());
                }
                else if (soldierType == "LieutenantGeneral")
                {
                    var id = info[1];
                    var firstName = info[2];
                    var lastName = info[3];
                    var salary = decimal.Parse(info[4]);
                    var lieutenantGeneralPrivates = new List<Private>();
                    for (int i = 5; i < info.Length; i++)
                    {
                        var privateSoldierId = info[i];
                        lieutenantGeneralPrivates.Add(privateSoldiers.Where(x => x.ID == privateSoldierId).FirstOrDefault());
                    }
                    var lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary, lieutenantGeneralPrivates);
                    Console.WriteLine(lieutenantGeneral.ToString());
                }
                else if (soldierType == "Engineer")
                {
                    var id = info[1];
                    var firstName = info[2];
                    var lastName = info[3];
                    var salary = decimal.Parse(info[4]);
                    var corps = info[5];
                    var engineerRepairs = new List<Repair>();
                    for (int i = 6; i < info.Length; i += 2)
                    {
                        var repairPartName = info[i];
                        var repairHoursWorked = int.Parse(info[i + 1]);
                        var repair = new Repair(repairPartName, repairHoursWorked);
                        engineerRepairs.Add(repair);
                    }
                    if (corps == "Airforces" || corps == "Marines")
                    {
                        var engineer = new Engineer(id, firstName, lastName, salary, corps, engineerRepairs);
                        Console.WriteLine(engineer.ToString());
                    }
                }
                else if (soldierType == "Commando")
                {
                    var id = info[1];
                    var firstName = info[2];
                    var lastName = info[3];
                    var salary = decimal.Parse(info[4]);
                    var corps = info[5];
                    var commandoMissions = new List<Mission>();
                    for (int i = 6; i < info.Length; i += 2)
                    {
                        var missionCodeName = info[i];
                        var missionState = info[i + 1];
                        var mission = new Mission(missionCodeName, missionState);
                        commandoMissions.Add(mission);
                    }
                    if (corps == "Airforces" || corps == "Marines")
                    {
                        var commando = new Commando(id, firstName, lastName, salary, corps, commandoMissions);
                        Console.WriteLine(commando.ToString());
                    }

                }
                else if (soldierType == "Spy")
                {
                    var id = info[1];
                    var firstName = info[2];
                    var lastName = info[3];
                    var codeNumber = int.Parse(info[4]);
                    var spy = new Spy(id, firstName, lastName, codeNumber);
                    Console.WriteLine(spy.ToString());
                }
            }
        }

    }
}
