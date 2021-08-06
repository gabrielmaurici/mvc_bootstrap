using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMvcBoot.Models;

namespace WebMvcBoot.Repository
{
    public abstract class BaseRepository<T> where T : BaseModels
    {
        private static List<T> lista = new List<T>();
        static int id = 1;
        public void Cadastrar(T model)
        {
            model.Id = id;
            id++;
            lista.Add(model);
        }
        public List<T> Listar()
        {
            return lista;
        }
        public T Listar(int id)
        {
            return lista.Find(v => v.Id == id);
        }
        public void Editar(T model)
        {
            int index = lista.FindIndex(v => v.Id == model.Id);
            lista[index] = model;
        }
        public void Deletar(int id)
        {
            lista.Remove(Listar(id));
        }
    }
}