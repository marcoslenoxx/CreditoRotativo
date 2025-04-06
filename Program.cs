const double TaxaIOFDia = 0.000082;
﻿const double TaxaIOFMes = 0.0038;
double pagamentoMinimo, taxaJuros;
decimal totalFatura, valorPagamentoMinimo, valorNaoPago;
decimal valorJuros, valorIOFMes, valorIOFDia, valorProximaFatura, custoRotativo;

Console.Clear();

Console.ForegroundColor= ConsoleColor.Yellow;
Console.WriteLine("--- Crédito Rotativo de Cartão de Crédito ---\n");
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.Black;
Console.Write("Valor total da fatura (R$)...: ");
totalFatura = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.Blue;
Console.Write("Pagamento mínimo (%).........: ");
Console.ResetColor();
pagamentoMinimo = Convert.ToDouble(Console.ReadLine()) / 100;

Console.ForegroundColor= ConsoleColor.Gray;
Console.Write("Taxa de juros mensais (%)....: ");
Console.ResetColor();
taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

valorPagamentoMinimo = totalFatura * Convert.ToDecimal(pagamentoMinimo);

valorNaoPago = totalFatura - valorPagamentoMinimo;
valorJuros = valorNaoPago * Convert.ToDecimal(taxaJuros);
valorIOFMes = valorNaoPago * Convert.ToDecimal(TaxaIOFMes);
valorIOFDia = valorNaoPago * Convert.ToDecimal(TaxaIOFDia * 30);

valorProximaFatura = valorNaoPago + valorJuros + valorIOFMes + valorIOFDia;
custoRotativo = valorProximaFatura - valorNaoPago;

Console.ForegroundColor= ConsoleColor.Blue;

Console.WriteLine($"\nPagamento mínimo..................: {valorPagamentoMinimo:C}");
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.DarkCyan;
Console.WriteLine("\nCaso seja pago o valor mínimo:\n");
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.Red;
Console.WriteLine($"Valor não pago....................: {valorNaoPago:C}");
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.Gray;
Console.WriteLine($"Juros.............................: {valorJuros:C}");
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.Magenta;
Console.WriteLine($"IOF mensal........................: {valorIOFMes:C}");
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.DarkMagenta;
Console.WriteLine($"IOF diário........................: {valorIOFDia:C}");
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.Black;
Console.WriteLine($"\nValor a pagar na próxima fatura...: {valorProximaFatura:C}");
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine($"Custo do crédito rotativo.........: {custoRotativo:C}");
Console.ResetColor();
