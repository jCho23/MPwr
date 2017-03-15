using System;
using Xamarin.Forms;

namespace MPwr
{
	public class FeedPage : ContentPage
	{
		public FeedPage()
		{
			var feedListView = new ListView();
			feedListView.ItemsSource = new string[]   {
				"Brandon",
				"Mike",
				"June",
				"April",
				"Tiffany"
			};
			feedListView.BackgroundColor = Color.FromHex("E2F8FF");
			feedListView.ItemSelected += (sender, e) =>
			 {
				 //Navigation.PushAsync(new IndividualWishPage(e.SelectedItem.ToString()));
			 };

			#region Initialize the Toolbar Add Button
			var addButtonToolBar = new ToolbarItem();
			addButtonToolBar.Icon = "Add";
			//addButtonToolBar.Clicked += async (sender, e) => await Navigation.PushAsync(new AddRegistryPage());

			ToolbarItems.Add(addButtonToolBar);
			#endregion

			var presentsImage = new Image { Aspect = Aspect.AspectFit };
			presentsImage.Source = ImageSource.FromFile("lightbulb.png");

			var lightbulbStack = new StackLayout
			{
				Children = { 
					presentsImage 
				}
			};
				
			Title = "Empower Feed";
			Content = feedListView;
				}
			};
		}


