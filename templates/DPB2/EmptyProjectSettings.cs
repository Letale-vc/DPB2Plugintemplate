using DreamPoeBot.Loki;
using DreamPoeBot.Loki.Common;
using System.ComponentModel;

namespace EmptyProject
{
	internal class EmptyProjectSettings : JsonSettings
	{
		private static EmptyProjectSettings _instance;
		public static EmptyProjectSettings Instance => _instance ??= new EmptyProjectSettings();

		private EmptyProjectSettings()
			: base(GetSettingsFilePath(Configuration.Instance.Name, $"{nameof(EmptyProjectSettings)}.json"))
		{
		}

		private int _settingNumber;

		[DefaultValue(256)]
		public int SettingNumber
		{
			get => _settingNumber;
			set
			{
				_settingNumber = value;
				NotifyPropertyChanged(() => SettingNumber);
			}
		}
	}
}