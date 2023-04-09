// Um programa de milhas resolve iniciar uma promoção em formato bumerangue, onde os pontos são transferidos com bônus e um percentual é retornado para sua conta.

double percentualBonus;
double percentualRetorno;
int pontosTransferidos;
double pontosBonus;
double pontosRetorno;

Console.WriteLine("--- Programa de Transferência de Pontos ---\n");

// Solicitar que digite percentuais
Console.Write("Digite o percentual de bônus (em %): ");
percentualBonus = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o percentual de retorno (em %): ");
percentualRetorno = Convert.ToDouble(Console.ReadLine());

// Solicitar que digite pontos a ser transferidos
Console.Write("Digite a quantidade de pontos a serem transferidos: ");
pontosTransferidos = Convert.ToInt32(Console.ReadLine());

// Calculos
pontosBonus = pontosTransferidos * (percentualBonus / 100); 
pontosRetorno = pontosTransferidos * (percentualRetorno / 100);

// Resultados 
Console.WriteLine($"\nQuantidade de pontos a reduzir na origem: {pontosTransferidos}");
Console.WriteLine($"Quantidade de pontos a acrescentar no destino: {pontosBonus + pontosRetorno}");