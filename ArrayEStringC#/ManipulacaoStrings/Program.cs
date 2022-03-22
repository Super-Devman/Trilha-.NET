using System;

namespace ManipulacaoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando vaiáveis string
            string blog = "Takeshi Kovacs - altered-carbon.fandom.com/wiki/Takeshi_Kovacs_(Books)";
            Console.WriteLine(blog);

            // Alterando uma string
            string blogReplace = blog.Replace("Kovacs", "Lev Kovacs");
            Console.WriteLine(blogReplace);

            // Obtendo uma parte da string utilizando Substring e Length
            string blogSub = blog.Substring(17, blog.Length - 17);
            Console.WriteLine(blogSub);

            // Obtendo textos separados por um separador
            string[] textos = blog.Split('-');

            foreach(string texto in textos)
            {
                Console.WriteLine("texto: " + texto);
            }

            // Juntando o texto e separando por um sinal de igual
            string textosComIgual = String.Join("=", textos);
            Console.WriteLine("Texto separado por sinal de igual: " + textosComIgual);

            // Verificando se o texto contém um outro texto
            Console.WriteLine("O texto contém a palavra Kovacs: " + blog.Contains("Kovacs"));

            // Adicionado e removendo strings
            string blogRemove = blog.Remove(15, 1);
            Console.WriteLine("Removendo o traço através de Remove: " + blogRemove);
            string blogInsert = blog.Insert(17, " https://");
            Console.WriteLine("Adicionando https: " + blogInsert);

            // Verificando se inicia ou finaliza com um determinado texto
            if(blog.StartsWith("Takeshi"))
            {
                Console.WriteLine("Inicia com Takeshi");
            }
            else
            {
                Console.WriteLine("Não inicia com Takeshi");
            }

            if(blog.EndsWith("(Books)"))
            {
                Console.WriteLine("Finaliza com (Books)");
            }
            else
            {
                Console.WriteLine("Não finaliza com (Books)");
            }

            // Comparando Strings
            string blog2 = "Takeshi Kovacs - altered-carbon.fandom.com/wiki/Takeshi_Kovacs_(Books)";

            Console.WriteLine("blog.Equals(blog2) = " + blog.Equals(blog2));
            Console.WriteLine("blog2.Equals(blog) = " + blog2.Equals(blog));
            Console.WriteLine("(blog2 == blog) = " + (blog2 == blog).ToString());
            Console.WriteLine("string.Compare(blog, blog2) = " + string.Compare(blog, blog2).ToString());
            Console.WriteLine("blog.CompareTo(blog2) = " + blog.CompareTo(blog2));

            // Retornando a primeia e última instância de um caractere
            int indicePrimeiro = blog.IndexOf("k");
            Console.WriteLine("Primeira ocorrência da letra k: " + indicePrimeiro.ToString());

            int indiceUltimo = blog.LastIndexOf("k");
            Console.WriteLine("Última ocorrência da letra k: " + indiceUltimo.ToString());

            // Verificando qual o tipo de um determinado elemento
            // Comparando as Strings
            string tipo = blog.GetType().ToString();
            string codigo_tipo = blog.GetTypeCode().ToString();

            Console.WriteLine("O tipo: " + codigo_tipo + " é = " + tipo);

            // Verificando se uma variável do tipo string está vazia ou não tem um valor inicializado
            if (!String.IsNullOrEmpty(blog2))
            {
                Console.WriteLine("blog não está vazio ou nulo");
            }

            blog2 = null;
            if (String.IsNullOrEmpty(blog2))
            {
                Console.WriteLine("blog = null");
            }

            // Manipulando strings para que seu conteúdo fique maiúsculo ou minúsculo
            string maiuscula = blog.ToUpper();
            Console.WriteLine(maiuscula);

            string minuscula = blog.ToLower();
            Console.WriteLine(minuscula);

            // Removendo espaços inicias e finais de uma string ou ambos
            string blogEspacado = "        Alexandre Tadashi - www.alexandretadashi.net      ";
            Console.WriteLine("String Original: " + blogEspacado);
            Console.WriteLine("Removendo espaços no inicio e fim: " + blogEspacado.Trim());
            Console.WriteLine("Removendo espaços no inicio: " + blogEspacado.TrimStart());
            Console.WriteLine("Removendo espaços no final: " + blogEspacado.TrimEnd());

            // Inserindo caracteres repetidas vezes em uma determinada posição (na esquerda ou direita)
            string acessos = "12900";
            acessos = acessos.PadLeft(8, '0');
            Console.WriteLine("Acesso do blog" + blog + " = " + acessos);
            acessos = acessos.PadRight(8, '1');
            Console.WriteLine("Novo acesso do blog" + blog + " = " + acessos);
        }
    }
}
