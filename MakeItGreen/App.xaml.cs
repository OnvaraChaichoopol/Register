﻿namespace MakeItGreen;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		//MainPage = new NavigationPage(new Login());
		MainPage = new NavigationPage(new Register());
	}
}
