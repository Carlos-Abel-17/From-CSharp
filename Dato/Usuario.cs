using primerfromulario.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerfromulario.Dato
{
    public class Usuario
    {
        List<UsuarioModels> lista = new List<UsuarioModels>();
        public void Guardar (UsuarioModels models)
        {
            lista.Add(models);

        }

        public List<UsuarioModels> Consultar()
        {
            return lista;
        }
    }
}
