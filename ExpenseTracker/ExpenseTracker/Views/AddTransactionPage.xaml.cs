using ExpenseTracker.ViewModels;

namespace ExpenseTracker.Views;

public partial class AddTransactionPage : ContentPage
{
	public AddTransactionPage(AddTransactionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}