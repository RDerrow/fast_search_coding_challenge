# Customer Point Calculator

## Overview
This was a coding challenge that I received from a recruiting firm.

This is a .Net Console application. The sample data paths are being fed directly into the console application via the relative path of the SampleData folder.

Once the data has been read from the "sample_transaction_data.csv" it generates a dictionary of transactions as they relate to a customer id.

Next, it reads data from the "sample_customer_data.csv" file and then finds the corresponding dictionary entry and calcualtes the points the customer has earned based on the transactions found for that customer.

Finally, it prints out each customer and how many points each customer has earned.

## Running
You can run the application if you have the .NET SDK install by running the command bellow:

```bash
    dotnet run fast_search_code_challenge.dll
```

The other way to run the application is if you open the project in Visual Studio Code and run the application in the debugger.