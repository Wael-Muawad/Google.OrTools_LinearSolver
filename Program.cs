// See https://aka.ms/new-console-template for more information
using Google.OrTools.LinearSolver;

Console.WriteLine("Hello, World!");


// Create the linear solver with the GLOP backend.
using Solver solver = Solver.CreateSolver("GLOP");
if (solver is null)
{
    return;
}

// Create the variables x and y.
using Variable x = solver.MakeNumVar(0.0, 1.0, "x");
using Variable y = solver.MakeNumVar(0.0, 2.0, "y");

Console.WriteLine("Number of variables = " + solver.NumVariables());
