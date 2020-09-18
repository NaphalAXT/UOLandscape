﻿namespace UOLandscape.UI
{
    internal interface IUIService
    {
        public ISettingsWindow SettingsWindow { get; }

        public IDockspaceWindow DockspaceWindow { get; }

        public INewProjectWindow NewProjectWindow { get; }

        public IToolsWindow ToolsWindow { get; }

        public IInfoOverlayWindow InfoOverlayWindow { get; }

        public IAboutWindow AboutWindow { get; }
    }
}