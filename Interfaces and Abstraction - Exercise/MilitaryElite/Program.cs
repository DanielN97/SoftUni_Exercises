using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, ISoldier> soldiersById = new Dictionary<string, ISoldier>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }

                string type = input[0];
                string id = input[1];
                string firstName = input[2];
                string lastName = input[3];

                if (type == nameof(Private))
                {
                    decimal salary = decimal.Parse(input[4]);

                    soldiersById[id] = new Private(id, firstName, lastName, salary);
                }
                else if (type == nameof(LieutenantGeneral))
                {
                    decimal salary = decimal.Parse(input[4]);

                    ILieutenantGeneral lieutenant = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < input.Length; i++)
                    {
                        if (soldiersById.ContainsKey(input[5]))
                        {
                            lieutenant.AddPrivate((IPrivate)soldiersById[input[i]]);
                        }
                    }

                    soldiersById[id] = lieutenant;
                }
                else if (type == nameof(Engineer))
                {
                    decimal salary = decimal.Parse(input[4]);

                    if (!Enum.TryParse(input[5], out Corps corps))
                    {
                        continue;
                    }

                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < input.Length; i++)
                    {
                        string part = input[i++];
                        int hours = int.Parse(input[i]);

                        engineer.AddRepair(new Repair(part, hours));
                    }

                    soldiersById[id] = engineer;
                }
                else if (type == nameof(Commando))
                {
                    decimal salary = decimal.Parse(input[4]);

                    if (!Enum.TryParse(input[5], out Corps corps))
                    {
                        continue;
                    }

                    ICommando commando = new Commando(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < input.Length; i++)
                    {
                        string codeName = input[i++];

                        if (!Enum.TryParse(input[i], out MissionState missionState))
                        {
                            continue;
                        }

                        commando.AddMission(new Mission(codeName, missionState));
                    }

                    soldiersById[id] = commando;
                }
                else if (type == nameof(Spy))
                {
                    int codeNumber = int.Parse(input[4]);

                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);

                    soldiersById[id] = spy;
                }
            }

            foreach (var soldier in soldiersById)
            {
                Console.WriteLine(soldier.Value);
            }
        }
    }
}
