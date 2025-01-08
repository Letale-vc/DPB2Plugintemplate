using System.Windows;


namespace EmptyProject
{
	/// <summary>
	/// Interaction logic for EmptyProjectGui.xaml
	/// </summary>
	public partial class EmptyProjectGui
	{
		public EmptyProjectGui()
		{
			InitializeComponent();
		}

		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			EmptyProjectSettings.Instance.SettingNumber++;
		}
	}
}
