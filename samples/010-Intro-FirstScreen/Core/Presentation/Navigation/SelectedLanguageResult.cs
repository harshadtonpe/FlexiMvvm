﻿using FlexiMvvm.ViewModels;

namespace FirstScreen.Core.Presentation.Navigation
{
    public class SelectedLanguageResult : Result
    {
        public SelectedLanguageResult(bool isSelected, string selectedLanguage)
        {
            IsSelected = isSelected;
            SelectedLanguage = selectedLanguage;
        }

        public bool IsSelected
        {
            get => Bundle.GetBool();
            private set => Bundle.SetBool(value);
        }

        public string SelectedLanguage
        {
            get => Bundle.GetString();
            private set => Bundle.SetString(value);
        }
    }
}
