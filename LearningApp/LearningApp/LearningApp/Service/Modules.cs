using System.Collections.Generic;
using LearningApp.Models;

namespace LearningApp.Service
{
    public class Modules
    {
        public static IEnumerable<Module> GetModules()
        {
            var modules = new List<Module>
            {
                new Module()
                {
                    ModuleId = 1,
                    ModuleName = "Module 1: Hello World",
                    ModuleDesc = "The module covers the basics of python programming language and variables.",
                    PhotoUrl = "helloworld.png",
                    PrgColor = "Green",
                    PrgWidth = 0.1f
                },
                new Module()
                {
                    ModuleId= 2,
                    ModuleName = "Module 2: Collections",
                    ModuleDesc = "In this module, there are collection structures that are used very frequently in programming.",
                    PhotoUrl = "box.png",
                    PrgColor = "Orange",
                    PrgWidth = 0.1f
                },
                new Module()
                {
                    ModuleId = 3,
                    ModuleName = "Module 3: Condition",
                    ModuleDesc = "Decision structures allow different steps of the program to be run depending on the conditions",
                    PhotoUrl = "choice.png",
                    PrgColor = "Yellow",
                    PrgWidth = 0.1f
                },
                new Module()
                {
                    ModuleId = 4,
                    ModuleName = "Module 4: Loops",
                    ModuleDesc = "Patterns that run one or more rows of transactions for a certain number of times or as long as they are somehow provided, depending on a condition, are called loops.",
                    PhotoUrl = "loop.png",
                    PrgColor = "Red",
                    PrgWidth = 0.1f
                }
                
            };

            return modules;
        }
    }
}
