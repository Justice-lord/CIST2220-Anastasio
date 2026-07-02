using ExpenseTracker.ViewModels;

namespace ExpenseTracker.Views;

public partial class TransactionsPage : ContentPage
{
	private readonly TransactionsViewModel _viewModel;
	public TransactionsPage(TransactionsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		_viewModel = viewModel;
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		if (BindingContext is TransactionsViewModel vm)
		{
			await vm.LoadTransactionsAsync();
		}
	}
}