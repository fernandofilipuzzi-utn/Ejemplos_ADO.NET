using Ej13_Administracion_Personas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13_Administracion_Personas.DAOs
{
    public interface IPersonasDAO
    {
        List<Persona> GetByAll();

        Persona GetById(int id);

        Persona Insert(Persona nuevo);

        bool Update(Persona actualizar);

        bool Delete(int Id);
    }
}
