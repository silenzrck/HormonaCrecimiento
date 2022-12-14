using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using HormonaCrecimiento.App.Dominio;

namespace HormonaCrecimiento.App.Persistencia
{
    public class RepositorioPacienteMemoria : IRepositorioPacienteMemoria
    {

        List<Paciente> pacientes;
        public RepositorioPacienteMemoria()
        {
            pacientes = new List<Paciente>(){
            new Paciente{
            Id=1,
            Nombre="Tatiana",
            Apellido="Rios",
            Documento="0106565321",
            Genero=Genero.Femenino,
            Direccion="Calle 58 N° 55 33",
            Latitud=56.7564F,
            Longitud=56.56232F,
            Ciudad="Popayan",
            FechaNacimiento  = new DateTime(1990,01,01)
               },
            new Paciente{
            Id=2,
            Nombre="Alirio",
            Apellido="Palechor",
            Documento="1062652245",
            Genero=Genero.Masculino,
            Direccion="Kra 14 N° 98 11",
            Latitud=98.231F,
            Longitud=10.2654F,
            Ciudad="Medellin",
            FechaNacimiento=new DateTime(1999,03,10)
               }
            };
        }
        public IEnumerable<Paciente> GetAll()
        {
            return pacientes;
        }
        public Paciente Add(Paciente paciente)
        {
            
            paciente.Id = pacientes.Max(p=> p.Id)+1;
            pacientes.Add(paciente);
            return paciente;
        }
        public Paciente Update(Paciente paciente)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int idPaciente)
        {
            throw new NotImplementedException();
        }
        public Paciente Get(int idPaciente)
        {
            return pacientes.SingleOrDefault(p=> p.Id == idPaciente);

        }

    }
}