using System;

namespace variaveis_instrucoes
{
  class Program
  {
    static void Declaracoes()
    { // tipos de declarações realizadas e suas saídas
      int a;
      int b = 2, c = 3;
      const int d = 4; //declaração de uma variável como constante; seu valor não pode ser alterado

      a = 1;

      Console.WriteLine(a + b + c + d); // será impresso o valor 10
    }

    static void InstrucaoIf(string[] args)
    { // args = argumento - instruções if else
      if (args.Length == 0)
      { // se não recebe nenhum argumento, executa o Console.WriteLine("Nenhum argumento");
        Console.WriteLine("Nenhum argumento");
      }
      else if (args.Length == 1)
      { // se recebe um argumento, executa o Console.WriteLine("Um argumento");
        Console.WriteLine("Um argumento");
      }
      else
      { // executa se nenhuma das condições anteriores forem falsas (não forem verdadeiras)
        Console.WriteLine($"{args.Length} argumentos");
      }
    }

    static void InstrucaoSwitch(string[] args)
    { // instruções switch case
      int numeroDeArgumentos = args.Length;

      switch (numeroDeArgumentos)
      {
        case 0: // se não recebe nenhum argumento, executa o Console.WriteLine("Nenhum argumento");
          Console.WriteLine("Nenhum argumento");
          break;
        case 1: // se recebe um argumento, executa o Console.WriteLine("Um argumento");
          Console.WriteLine("Um argumento");
          break;
        default: // executa se nenhuma das condições anteriores forem falsas (não forem verdadeiras)
          Console.WriteLine($"{numeroDeArgumentos} argumentos");
          break;
      }
    }

    static void InstrucaoWhile(string[] args)
    { // instruções de repetição while
      int i = 0;

      while (i < args.Length)
      { // vai executar o Console.WriteLine(args[i]); enquanto args.Length for menor que i
        Console.WriteLine(args[i]);
        i++; // somando 1 no i cada vez que é executado
      }
    }

    static void InstrucaoDo(string[] args)
    { // instruções de repetição do while
      string texto;

      do
      { // executa o do antes da condição while (enquanto)
        texto = Console.ReadLine();
        Console.WriteLine(texto);
      } while (!string.IsNullOrEmpty(texto)); // enquanto o texto não (!) for nulo (vazio), retorna true ou false
      // se fosse (!string.IsNullOrEmpty(texto)) seria, enquanto o texto for nulo (vazio), retorna true ou false
    }

    static void InstrucaoFor(string[] args)
    { // instrução de repetição for
      for (int i = 0; i < args.Length; i++)
      {
        Console.WriteLine(args[i]); // executa este comando até o valor de args.Length for menor que i
      }
    }

    static void InstrucaoForeach(string[] args)
    { // instruções de repetição foreach
      foreach (string s in args)
      { // para cada string s no array, imprima s
        Console.WriteLine(s);
      }
    }

    static void InstrucaoBreak(string[] args)
    { // instruções break
      while (true)
      {
        string s = Console.ReadLine(); // enquanto verdadeiro leia e salve na variável string s

        if (string.IsNullOrEmpty(s))
        {
          break; // pausa a condição e vai para a próxima linha de comando
          // o break funciona com o while e com o for
        }

        Console.WriteLine(s);
      }
    }

    static void InstrucaoContinue(string[] args)
    { // instruções continue
      for (int i = 0; i < args.Length; i++)
      {
        if (args[i].StartsWith("/"))
        {
          continue; // se começar com uma "/" continua para a próxima linha de comando
        }

        Console.WriteLine(args[i]);
      }
    }

    static void InstrucaoReturn(string[] args)
    { // instruções return
      // método Somar() é visível apenas dentro de InstrucaoReturn()
      int Somar(int a, int b)
      {
        return a + b; // retornando a soma de a + b
      }

      Console.WriteLine(Somar(1, 2)); // imprimindo a soma de 1 e 2 após passar os valores por referência para o método Soma()
      Console.WriteLine(Somar(3, 4)); // imprimindo a soma de 3 e 4 após passar os valores por referência para o método Soma()
      Console.WriteLine(Somar(5, 6)); // imprimindo a soma de 5 e 6 após passar os valores por referência para o método Soma()

      return; // não retorna nada devido o método ser void
    }

    static void InstrucoesTryCatchFinallyThrow(string[] args)
    { // instruções try, catch, finally e throw trabalham com exceções
      // método Dividir() é visível apenas dentro de InstrucoesTryCatchFinallyThrow()
      double Dividir(double x, double y)
      {
        if (y == 0)
          throw new DivideByZeroException(); // tratando a exceção por divisão por zero

        return x / y; // retornando a divisão de x por y
      }

      try
      { // faz tiver dentro do try faz, se der erro, faz as exceções (catch)
        if (args.Length != 2)
        {
          throw new InvalidOperationException("Informe 2 números");
        }

        double x = double.Parse(args[0]); // atribuindo valor a posição 0 para x
        double y = double.Parse(args[1]); // atribuindo valor a posição 1 para y

        Console.WriteLine(Dividir(x, y));  // imprimindo a divisão de x e y após passar os valores por referência para o método Dividir()
      }
      catch (InvalidOperationException e)
      { // exceção para operação inválida, deve passar dois valores para o método Dividir()
        Console.WriteLine(e.Message);
      }
      catch (Exception e)
      {  // exceção para erro padrão de catch, por divisão por zero
        Console.WriteLine($"Erro genérico: {e.Message}");
      }
      finally
      { // será executado após passar pelas instruções try e catch
        Console.WriteLine("Até breve!");
      }
    }

    static void InstrucaoUsing(string[] args)
    { // instruções using
      using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
      { // using elimina da memória os valores que serão impressos 
        w.WriteLine("Line 1");
        w.WriteLine("Line 2");
        w.WriteLine("Line 3");
      }
    }
  }
}