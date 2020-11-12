using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsPortal.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Trabalhando com Asp.Net",
                Autor = "Gabriel",
                Data = DateTime.Today,
                Conteudo = "Essa é a primeira fase de trabalho com Asp.NET, meio que perdido estou mas está sendo bom programar com esse framework."

            });
            
            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Nova",
                Autor = "Gabriel",
                Data = DateTime.Today,
                Conteudo = "Essa é uma nova notícia feita.Tem que ter mais de 100 caracteres é isso. Lorem Lorem Lorem Lorem Lorem Lorem Lorem Lorem"

            });
            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Trabalhando com Asp.Net",
                Autor = "Gabriel",
                Data = DateTime.Today,
                Conteudo = "Essa é a primeira fase de trabalho com Asp.NET, meio que perdido estou mas está sendo bom programar com esse framework."

            });
            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Trabalhando com Asp.Net",
                Autor = "Gabriel",
                Data = DateTime.Today,
                Conteudo = "Essa é a primeira fase de trabalho com Asp.NET, meio que perdido estou mas está sendo bom programar com esse framework."

            });
            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Trabalhando com Asp.Net",
                Autor = "Gabriel",
                Data = DateTime.Today,
                Conteudo = "Essa é a primeira fase de trabalho com Asp.NET, meio que perdido estou mas está sendo bom programar com esse framework."

            });
            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Trabalhando com Asp.Net",
                Autor = "Gabriel",
                Data = DateTime.Today,
                Conteudo = "Essa é a primeira fase de trabalho com Asp.NET, meio que perdido estou mas está sendo bom programar com esse framework."

            });
        }
    }
}