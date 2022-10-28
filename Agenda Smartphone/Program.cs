using DesafioPOO.Models;
using System;   

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero : "996144012", modelo : "I10", imei : "132548642", memoria : 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero : "996012415", modelo : "X", imei : "15796543", memoria : 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");



