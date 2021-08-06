using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMvcBoot.Models;

namespace WebMvcBoot.Repository
{
    public class RepositoryViagens
    {
        static List<Viagens> listaViagens = new List<Viagens>();
        static int id = 1;
        public void Cadastrar(Viagens model)
        {
            model.Id = id;
            id++;
            listaViagens.Add(model);
        }
        public List<Viagens> Listar()
        {
            return listaViagens;
        }
        public Viagens Listar(int id)
        {
            return listaViagens.Find(v => v.Id == id) ;
        }
        public void Editar(Viagens model)
        {
            int index = listaViagens.FindIndex(v => v.Id == model.Id);
            listaViagens[index] = model;
        }
        public void Deletar(int id)
        {
            listaViagens.Remove(Listar(id));
        }
    }
}