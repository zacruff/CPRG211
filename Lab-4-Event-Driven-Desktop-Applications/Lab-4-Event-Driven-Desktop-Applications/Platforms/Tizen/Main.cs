using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Lab_4_Event_Driven_Desktop_Applications;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
