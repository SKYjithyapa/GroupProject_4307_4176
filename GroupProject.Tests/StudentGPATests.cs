using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using GroupProject.Models;

namespace GroupProject.Tests
{
    public class StudentGPATests
    {
        [Fact]
        public void CalcGPA_ShouldReturnZero_WhenModulesListIsEmpty()
        {
            var student = new Student
            {
                Modules = new List<Module>()
            };

            double gpa = student.CalcGPA();

            gpa.Should().Be(0.0);
        }

        [Fact]
        public void CalcGPA_ShouldCalculateCorrectGPA_WhenModulesListHasGrades()
        {
            var modules = new List<Module>
            {
                new Module { ModuleCode = "CE1210", Grade = 'A' },
                new Module { ModuleCode = "EE2220", Grade = 'B' },
                new Module { ModuleCode = "EE1301", Grade = 'C' }
            };

            var student = new Student
            {
                Modules = modules
            };

            double gpa = student.CalcGPA();

            gpa.Should().BeApproximately(2.85, 0.01);
        }

        [Fact]
        public void CalcGPA_ShouldReturnZero_WhenAllModuleGradesAreE()
        {
            var modules = new List<Module>
            {
                new Module { ModuleCode = "CS2101", Grade = 'E' },
                new Module { ModuleCode = "ME8202", Grade = 'E' },
                new Module { ModuleCode = "EN7301", Grade = 'E' }
            };

            var student = new Student
            {
                Modules = modules
            };

            double gpa = student.CalcGPA();

            gpa.Should().Be(0.0);
        }


        [Fact]
        public void CalcGPA_ShouldCalculateCorrectGPA_WhenModulesListHasSingleModule()
        {
            var modules = new List<Module>
            {
                new Module { ModuleCode = "CS1210", Grade = 'B' }
            };

            var student = new Student
            {
                Modules = modules
            };

            double gpa = student.CalcGPA();

            gpa.Should().BeApproximately(3.0, 0.01);
        }

        [Fact]
        public void CalcGPA_ShouldReturnZero_WhenModulesListHasInvalidGrades()
        {
            var modules = new List<Module>
            {
                new Module { ModuleCode = "CS5101", Grade = 'X' },
                new Module { ModuleCode = "ME7202", Grade = 'Y' },
                new Module { ModuleCode = "EE5301", Grade = 'Z' }
            };

            var student = new Student
            {
                Modules = modules
            };

            double gpa = student.CalcGPA();

            gpa.Should().Be(0.0);
        }

        [Fact]
        public void CalcGPA_ShouldCalculateCorrectGPA_WhenModulesListHasMixedValidAndInvalidGrades()
        {
            var modules = new List<Module>
            {
                new Module { ModuleCode = "CE4101", Grade = 'A' },
                new Module { ModuleCode = "ME5202", Grade = 'X' },
                new Module { ModuleCode = "EE7301", Grade = 'B' },
                new Module { ModuleCode = "IS4101", Grade = 'Y' }
            };

            var student = new Student
            {
                Modules = modules
            };

            double gpa = student.CalcGPA();

            gpa.Should().BeApproximately(3.25, 0.01);
        }
    }
}
