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