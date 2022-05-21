using System;
using System.Globalization;

Console.Clear();

//var data = new DateTime(); // Tipo primitivo - estrutura padrão
//var data = DateTime.Now;// Data de agora
// var data = new DateTime(1990, 03, 29, 11, 40, 30);
// Console.WriteLine(data);
// Console.WriteLine(data.Year);
// Console.WriteLine(data.Hour);
// Console.WriteLine(data.Minute);
// Console.WriteLine((int)data.DayOfWeek);
// Console.WriteLine(data.DayOfWeek);


//var data =  DateTime.Now;
// var formato = String.Format("{0:dd/MM/yy - hh:mm:ss:ff zz}", data); // ff= Fração de segundo e zz = Timezone - O fuso horário.
// Console.WriteLine(formato);


// Console.WriteLine(data.AddDays(1));

// if (data.Month == DateTime.Now.Month)
//     Console.WriteLine("É igual!");

//DateTime?  data2= null;
//Console.WriteLine(data2);

// var pt = new CultureInfo("pt-BR");
// var de = new CultureInfo("de-DE");
// var atual = CultureInfo.CurrentCulture;
// Console.WriteLine(data.ToString("d", pt));
// Console.WriteLine(data.ToString("d", de));
// Console.WriteLine(data.ToString("d", atual));
// Console.WriteLine(string.Format("{0:D}", data, de));
// Console.WriteLine(string.Format("{0:D}", data, pt));

//var dataTime = DateTime.UtcNow; // horário global
// Console.WriteLine(dataTime);
// Console.WriteLine(dataTime.ToLocalTime());

// var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland"); // exibir hra da Australia
// Console.WriteLine(timezoneAustralia);

// var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dataTime, timezoneAustralia); // Converter pra hora Australia
// Console.WriteLine(horaAustralia);

// var horaAtual = TimeZoneInfo.ConvertTimeToUtc(horaAustralia, timezoneAustralia); // Converter hora Australia pra UTC
// Console.WriteLine(horaAtual);

//  var timezones = TimeZoneInfo.GetSystemTimeZones();
//     foreach (var timezone in timezones)
//     {
//         Console.WriteLine(timezone.Id);
//         Console.WriteLine(timezone);
//         Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dataTime, timezone));
//         Console.WriteLine("_________");
//     }

// var timeSpan = new TimeSpan(); //Fazer calculos de horas
// Console.WriteLine(timeSpan);

// var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
// Console.WriteLine(timeSpanHoraMinutoSegundo);

// var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
// Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

// var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
// Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

// Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
// Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
// Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

 Console.WriteLine(DateTime.DaysInMonth(2020, 2));// Número de dias no mês
 Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));// Método criado a mão pra verificar se é sabado ou domingo
 Console.WriteLine(DateTime.Now.IsDaylightSavingTime());// Método já existente para verfificar se é horário de verão


        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }