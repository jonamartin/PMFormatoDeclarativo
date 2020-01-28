using System;
using Proyectmanager;
public class Task : Sprintbacklog
{
    private string complejidad;
    private double Hora;
    private string userstory;

    public Task(string userstory, double hora,string complejidad)
    {
        this.complejidad=complejidad;
        this.Hora=hora;
        this.userstory=userstory;
    }
    public string definircomplejidad(float horas)
        {
        if(horas<3&&horas>0) 
        {
        this.complejidad = "Facil";                                             // decir "this"  es hacer referencia a las variables que se crean arriba del constructor
        }
        else if(horas<13&&horas>2)
        {
        this.complejidad = "Complicado";
        }
        else 
        {
        this.complejidad = "Super Complicado";
        }
        return complejidad;
        }

        public double calcularhstask()
        {
            double horas;

            if(this.complejidad.Equals("Complicado"))                               //   complejidad == "Complicado"     se puede decir que es sinonimo o igual a 
            {                                                                       //   complejidad.Equals("Complicado")    la diferencia que el de arriba es un error y este es correcto
                horas = this.Hora * 1.2;
               
            }else{
                
                if(this.complejidad.Equals("Super Complicado")){
                    horas = this.Hora * 1.5;
                }else{
                    horas = this.Hora * 1;
                }
            
            
            }
            
            return horas;
        }
}
