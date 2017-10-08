# Unity3DLocalization
Localization strings system by code or component

Guide

    *Clone GoogleDrive https://docs.google.com/a/jbotero.com/spreadsheets/d/1Y048Io6k6gurIk9e_j8LmvTWeNfKw3aF2ACcDm0FBk0/edit?usp=sharing

    *On the sheet LocalizationBase edit or add cells on key

    *Edit the language "en" and check the others languages update values

    *On the sheet Localization to XML copy only the green cells and paste this cells between key <Section> here... </Section> on the Unity Project file: Assets/Resources/Language/LocalizationText.xml

Usage

    A) Component: Create or edit Unity Label whith named gameObject with ID sheet cell and add component LocalizationComponent. (this script gey key of gameObjectName) Example Scene LocalizationDemoScene Component LanguageByComponent
    B) Script: Create sctipt and add a Unity Label. use MyGameObject.text = LocalizationText.GetText(KEY); Example Scene LocalizationDemoScene Component LanguageByCode

    This examples functions run on Update you can move this function where you need to improve the performance
    
Developed by Johnatan Botero
johnatan@nibostudio.com
