﻿namespace DatePickerMemoryLeak;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
	}
}
