//Horário do Relógio
using System.Globalization;

DateTime data = DateTime.Now;
Console.WriteLine(data);

//Formato data DD/MM/AAAA
Console.WriteLine(data.ToString("dd/MM/yyyy"));

//Formato hora HH:MM
Console.WriteLine(data.ToString("hh:mm") + "h");

//Formato data DD/MM/AAAA
Console.WriteLine(data.ToShortDateString());

//Formato hora HH:MM
Console.WriteLine(data.ToShortTimeString());

//Conversão de DATAS
string dataString1 = "2022-04-17 18:00";
DateTime data1 = DateTime.Parse(dataString1);
Console.WriteLine(data1);

//Conversão de DATAS
string dataString2 = "2022.04.17 18:00";
DateTime data2 = DateTime.Parse(dataString2);
Console.WriteLine(data2);

//Conversão de DATAS
string dataString3 = "17.04.2022 18:00";
DateTime data3 = DateTime.Parse(dataString3);
Console.WriteLine(data3);

string dataString4 = "2022-12-17 18:00";
DateTime.TryParseExact(dataString4, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data4);
Console.WriteLine(data4);

//AAAAMMDD
string dataString5 = "20221216 18:00";
DateTime.TryParseExact(dataString5, "yyyyMMdd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data5);
Console.WriteLine(data5);

//DDMMAAAA
string dataString6 = "15122022 18:00";
DateTime.TryParseExact(dataString6, "ddMMyyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data6);
Console.WriteLine(data6);

String dataString7 = "2022-12-27 18:00";
bool dataValida = DateTime.TryParseExact(dataString7, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data7);

if (dataValida)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data7}");
}
else
{
    Console.WriteLine($"{dataString7} não é uma data válida!");
}

//Calcular em dias - Exemplo boleto pago.
DateTime entradaEmpresa = new DateTime(2021, 1, 1);
TimeSpan quantoTempoDeEmpresa = new DateTime.now - entradaEmpresa;



