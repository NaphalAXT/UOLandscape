﻿namespace UOLandscape.Configuration
{
    internal sealed class AppSettingsProvider : IAppSettingsProvider
    {
        private readonly IConfigurationLoader _configurationLoader;
        private readonly IConfigurationSaver _configurationSaver;

        public AppSettingsProvider(
            IConfigurationLoader configurationLoader,
            IConfigurationSaver configurationSaver)
        {
            _configurationLoader = configurationLoader;
            _configurationSaver = configurationSaver;
            AppSettings = new AppSettings();
            this.Load();
        }

        public AppSettings AppSettings { get; private set; }

        public void Load()
        {
            AppSettings = _configurationLoader.LoadConfiguration<AppSettings>("config.json") ?? new AppSettings();
        }

        public void Save()
        {
            _configurationSaver.SaveConfiguration("config.json", AppSettings);
        }
    }
}