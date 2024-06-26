﻿using GymBro.ViewModels;

namespace GymBro.Views;

public partial class TrainingDaysPage : ContentPage
{
    private TrainingDaysViewModel _trainingDaysVM;
    public TrainingDaysPage(TrainingDaysViewModel trainingDaysVM)
    {
        InitializeComponent();

        BindingContext = trainingDaysVM;
        _trainingDaysVM = trainingDaysVM;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await _trainingDaysVM.LoadTrainingPlans();
    }
}
