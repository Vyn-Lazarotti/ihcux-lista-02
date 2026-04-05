using System;

namespace TerminalSuporteConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Status do sistema: OPERACIONAL");
      Console.WriteLine("---------------------");
      // Heurística #6: Reconhecimento em vez de Recordação
      Console.WriteLine("Comandos disponíveis: \n>PING - testar conexão \nRESET - reiniciar servidor (critico) \nHELP - ajuda \nEXIT - encerrar terminal");
      Console.WriteLine("Digite o comando: ");
      string comando = Console.ReadLine().ToUpper();
      
      switch (comando)
      {
        case "PING":
          Console.Clear();
          Console.WriteLine("--- DIAGNÓSTICO DE REDE ---");
          Console.WriteLine("Formato de IP esperado: 100.100.0.1 (Somente números e pontos)"); // Heurística #10: Documentação contextual
          Console.WriteLine("Digite o IP do destino: ");
          string ip = Console.ReadLine();

           if (string.IsNullOrEmpty(ip) || !ip.Contains(".")) // Heurística #5: Prevenção de erros
            {
              Console.WriteLine("IP inválido! Certifique-se de usar o formato adequado (ex: 100.100.0.1)");
              return;
            }

            Console.WriteLine($"\n [IHCUX] Enviando pacotes para {ip}...");
            System.Threading.Thread.Sleep(2000); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enviado com sucesso!");
            Console.ResetColor();
            Console.ReadKey();
            break;

        case "RESET":
          Console.Clear();
          Console.WriteLine("Você selecionou o reboot do servidor");  // Heurística #10: Documentação contextual
          System.Threading.Thread.Sleep(2000); 
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("Deseja continuar? (1 para Sim/0 para Não): ");
          int resposta = Convert.ToInt32(Console.ReadLine());
          Console.ResetColor();
          Console.ReadKey();
          if (resposta == 1) // Heurística #5: Prevenção de erros
          {
            Console.WriteLine("Reiniciando...");
            Console.WriteLine("Sistema online!");
            break;
          } else if (resposta == 0) // Heurística #5: Prevenção de erros
          {
            break;
          } else // Heurística #5: Prevenção de erros
          {
            Console.WriteLine("Erro! Valor inválido!");
            break;
          }

        case "HELP":
          Console.Clear();
          Console.WriteLine("--- Central de Ajuda ---");  // Heurística #10: Documentação contextual
          Console.WriteLine("- PING: Verifica se o servidor está funcionando");
          Console.WriteLine("- RESET: Reinicia o servidor");
          Console.WriteLine("- EXIT: Desliga o programa");
          break;

        case "EXIT":
          System.Threading.Thread.Sleep(2000); 
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Deseja continuar? (1 para Sim/0 para Não): ");  // Heurística #10: Documentação contextual
          int resposta2 = Convert.ToInt32(Console.ReadLine());
          Console.ResetColor();
          Console.ReadKey();
          if (resposta2 == 1) // Heurística #5: Prevenção de erros
          {
            Console.WriteLine("Desligando...");
            break;
          } else if (resposta2 == 0) // Heurística #5: Prevenção de erros
          {
            break;
          } else // Heurística #5: Prevenção de erros
          {
            Console.WriteLine("Erro! Valor inválido!");
            break;
          }

        default: // Heurística #5: Prevenção de erros
          Console.WriteLine("Comando inválido!"); 
          break;
      } 
    }

    }
}
