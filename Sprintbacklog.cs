using System;
using Proyectmanager;
using System.Collections.Generic;
public class Sprintbacklog : ProductBacklog
    {
    public double horas;
    public string nombre;
    public Sprintbacklog()
    {
    }


    public string userstory;
    public static string complejidad;
    public static List<Task> listTask = new List <Task>();
    
    public string solicitarus( )
        {
        Console.WriteLine("Ingrese la user story");
        this.userstory = Console.ReadLine();                // aca guarda en su variable userstory

        return this.userstory;                              // aca retorna ese valor para optenerlo en el programa principal 
        }


    public double solicitarhs()
        {
        Console.WriteLine("Ingrese la cantiad de horas de la carta seleccionada en estimacion");
        double horas;
        horas = double.Parse(Console.ReadLine());
        return horas;
        }
       
            
        
}
