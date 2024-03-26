using _240325_01.Models;

clinica c1 = new clinica();
clinica.InstanceCount = 1;
c1.ObjectCount = 1;

clinica c2 = new clinica();
clinica.InstanceCount++;
c2.ObjectCount = 10;

Console.WriteLine($"Valor C1: {c1.ObjectCount}");

Console.WriteLine($"Instance Count: {c2.ObjectCount}");