using System;
using Proyectmanager;
using System.Collections.Generic;
using System.Text;

namespace Nueva_carpeta
{
    public class Program 
    {
        static void Main(string[] args)
        {
        List <Task> sprint;
        List <List <Task>> proyecto = new List <List <Task>>();       
        
        Task tare;
        bool logico=true;
        bool logico2=true;
        string comple;
        string inicio;
        string l;
        double L;
        double horas;
        List<double> lista = fibonacci();
        List<string> clasificacion = new List<string>()
        {
            "Facil",
            "Complicado",
            "Super Complicado"
        };



       

        Console.WriteLine("No hay Sprint en el Proyecto");

        while(logico){

                    Console.WriteLine("¿Desea agregar una Sprint? S/N");
                    inicio = Console.ReadLine();
                   
                   
                    if(inicio.Equals("S"))
                    {


                                sprint = new List <Task>();
                                logico2=true;

                                
                                while(logico2) {
                            
                            
                                            Console.WriteLine("Ingrese Nombre para Nueva Tarea dentro del Sprint - sino 'Salir' ");
                                            inicio = Console.ReadLine();
                                            
                                        
                                        
                                            if(inicio.Equals("Salir")){
                                                proyecto.Add(sprint);
                                                logico2=false;



                                            }else{
                                                
                                                Console.WriteLine("Ingrese hora estimada");
                                                l = Console.ReadLine();
                                                L = double.Parse(l);
                                                while(!lista.Contains(L)){
                                                    Console.WriteLine("Hora No Perteneciente a la serie... Ingrese otra Hora");
                                                    l = Console.ReadLine();
                                                    L = double.Parse(l);
                                                }


                                                
                                                Console.WriteLine("Complejidad: 'Facil' - 'Complicado' - 'Super Complicado'");
                                                comple = Console.ReadLine();
                                                while(!clasificacion.Contains(comple)){
                                                    Console.WriteLine("Incorrecto.Elija una: 'Facil' - 'Complicado' - 'Super Complicado'");
                                                    comple = Console.ReadLine();
                                                }
                                                tare= new Task(inicio,L,comple);
                                                sprint.Add(tare);

                                            }
                                }
                                

                    }else{
                        logico=false;
                    }

        }


        
        double horaTotal=0.0d;

        foreach (List<Task> sprintt in proyecto)
        {   
            foreach (Task taskk in sprintt)
            {
                horaTotal=horaTotal + taskk.calcularhstask();
                Console.WriteLine( taskk.calcularhstask());
            }
            
        }

        Console.WriteLine("Las horas Totales del Proyecto son: {0:N}",horaTotal);

      






        
       

        //Sprintbacklog.listTask.Add(new Task{userstory = tarea.solicitarus(), complejidad = clasificar.definircomplejidad(horas), horas = clasificar.calcularhstask(horas)});
        
        
        
         
        //Console.WriteLine("La cantidad de horas estimada de esta tarea es {0} hs",horas);

        //Console.WriteLine("La user story de la tarea es: {0}",userstory);  

        //Console.WriteLine("La tarea esta clasificada como: {0}",complejidad);  

        }





        public static List<double> fibonacci(){
            int x=1;
            int y=1;
            bool L=true;

            List <double> numeros= new List<double>();

            numeros.Add(y);
            while((x+y)<100){
                    if(L){
                        x=x+y;
                        numeros.Add(x);
                        L=false;
                    }else{
                        y=y+x;
                        numeros.Add(y);
                        L=true;
                        }
            
            }
            numeros.Add(100);
            return numeros;
        }


    }
}
