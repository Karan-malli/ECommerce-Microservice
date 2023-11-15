# ECommerce-Microservice

Project details:
 This project has 4 projects:
1.	Orders
2.	Products
3.	Customers
4.	Search
Each project has a specific functionality.
User can search orders of customer. For this Search service will invoke API of Order mircoservice.

Key Points for implementation:
1.	In order to make search service aware of which APIs are required, we will store APIs URL in appsettings.json
Example:  "Services": {
    "Customers": "https://localhost:7120",
    "Products": "https://localhost:7253",
    "Orders": "https://localhost:7038"
  }
2.	Create Builder for Order Service in Program.cs of Search Service.
Example:  builder.Services.AddHttpClient("OrderService", Config =>
            {
                Config.BaseAddress = new Uri(builder.Configuration["Services:Orders"]);
            });
3.	Invoke GetOrder of Order Controller of Order project from search product.
Example:
public async Task<List<Order>> GetOrdersAsync(int customerId)
        {
            var client = httpClientFactory.CreateClient("OrderService");
     var response = client.GetAsync($"Orders/GetOrder?CustomerID={customerId}");
            var content = await response.Result.Content.ReadAsByteArrayAsync();
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            var result = JsonSerializer.Deserialize<List<Order>>(content, options);
            return result;
4.	
        }
	

