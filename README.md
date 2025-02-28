# E-Commerce App (ASP.NET Core MVC)

This is a simple e-commerce web application built using **ASP.NET Core MVC**. It allows users to view products, place orders, and view their order history.

## Features
- **Product List**: Display a list of products with details.
- **Order Placement**: Users can place orders for products.
- **Order History**: Users can view their order history with detailed information.
- **Responsive Design**: Built with Bootstrap for a clean and responsive UI.


## Technologies Used
- **ASP.NET Core MVC**: For building the web application.
- **Bootstrap**: For styling and responsive design.
- **C#**: Backend logic and model definitions.
- **Razor Views**: For rendering dynamic HTML content.
  
## Project Structure

ECommerceApp/
├── Controllers/
│   ├── HomeController.cs
│   ├── ProductController.cs
│   └── OrderController.cs
├── Data/
│   └── ProductData.cs
├── Models/
│   ├── Product.cs
│   ├── Order.cs
│   ├── OrderDetails.cs
│   ├── User.cs
│   ├── OrderHistoryViewModel.cs
│   └── ProductViewModel.cs
├── Views/
│   ├── Home/
│   ├── Product/
│   └── Order/
├── wwwroot/
└── Program.cs


## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/shahad-jeza/ELM_training_assigment2_ASP.NET_e_commerce.git

2. Navigate to the project folder:
   ```bash
   cd ECommerceApp
3. run the app
   ```bash
   dotnet run
