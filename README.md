# fetchapp-dotnet-2.0


A complete refactor of the FetchApp dotnet library.


# Proposed Syntax

## Getting Account Information

```cs
// Create a new FetchApp instance
FetchApp fetch = new FetchApp();

// Set the Authentication data (needed for all requests)
fetch.AuthenticationKey = "demokey";
fetch.AuthenticationToken = "demotoken";

try
{
  // Let's grab our Account data to make sure that everything is working!
	AccountDetail account = fetch.getAccountDetails(); //    That was easy!
	
	// Let's write some of the available Data to the console!
	Console.WriteLine(account.AccountID);
	Console.WriteLine(account.AccountName);
	Console.WriteLine(account.BillingEmail);
	Console.WriteLine(account.EmailAddress);
	Console.WriteLine(account.URL);
	Console.WriteLine(account.ItemDownloadLimit);
	Console.WriteLine(account.OrderExpirationInHours);
}
catch (AuthenticationException e)
{
	// This will occur on any call if the AuthenticationKey and AuthenticationToken are not set.
	Console.WriteLine(e.Message);
}
```

## Getting information about Orders

```cs
// Create a new FetchApp instance
FetchApp fetch = new FetchApp();

// Set the Authentication data (needed for all requests)
fetch.AuthenticationKey = "demokey";
fetch.AuthenticationToken = "demotoken";

try
{
	// It is easy to grab all of your orders
	List<Order> orders = fetch.getOrders();

	// It is also easy to grab only orders which are Open
	// List<Order> orders = fetch.getOrders(OrderStatus.Open);
	// 
	// Or Expired!
	// List<Order> orders = fetch.getOrders(OrderStatus.Expired);
	// 
	// You may also want to paginate the results as follows:
	//
	// int itemsPerPage = 25;
	// int pageNumber = 2;
	// List<Order> orders = fetch.getOrders(OrderStatus.Open, itemsPerPage, pageNumber);
	foreach (Order order in orders)
	{
		// Dealing with individual Orders is easy as well.
		// Here we can expire all orders that took place on May 26, 2013
		if (order.CreationDate.Date.Equals(new DateTime(2013, 5, 26)))
		{
			order.expire();
		}
		else
		{
			// Getting additional information about the order is painless:

			// Order Items
			List<OrderItem> items = order.getItems();

			// Downloads
			List<OrderDownload> downloads = order.getDownloads();

			// Statistics
			OrderStatistic stats = order.getStatistics();

			// Sending a download email is simple:
			// Here we'll resend the download email if nothing has been downloaded.
			if (stats.DownloadCount == 0)
			{
				// Send the email with the default options
				order.sendDownloadEmail();
				// Send the email and reset the expiration date
				order.sendDownloadEmail(true);
				// Send the email and explicitly set the expiration date to infinity (and beyond)
				order.sendDownloadEmail(expirationDate: DateTime.MaxValue);// or order.sendDownloadEmail(false, DateTime.MaxValue);
				// Send the email and set the expiration date and download limit
				order.sendDownloadEmail(expirationDate: DateTime.MaxValue, downloadLimit: 5);// or order.sendDownloadEmail(false, DateTime.MaxValue, 5);
			}
		}

	}
}
catch (AuthenticationException e)
{
	// This will occur on any call if the AuthenticationKey and AuthenticationToken are not set.
	Console.WriteLine(e.Message);
}
```