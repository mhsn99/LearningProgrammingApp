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
                    ModuleName = "Module 1: Hello World",
                    ModuleDesc = "The module covers the basics of python programming language and variables.",
                    PhotoUrl = "helloworld.png"
                },
                new Module()
                {
                    ModuleName = "Module 2: Collections",
                    ModuleDesc = "In this module, there are collection structures that are used very frequently in programming.",
                    PhotoUrl = "box.png"
                },
                new Module()
                {
                    ModuleName = "Module 3: Condition",
                    ModuleDesc = "Decision structures allow different steps of the program to be run depending on the conditions",
                    PhotoUrl = "choice.png"
                },
                new Module()
                {
                    ModuleName = "Module 4: Loops",
                    ModuleDesc = "Patterns that run one or more rows of transactions for a certain number of times or as long as they are somehow provided, depending on a condition, are called loops.",
                    PhotoUrl = "loop.png"
                }
                
            };

            return modules;
        }
    }
}
