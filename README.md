# 🛒 MarketMini Console  

**MarketMini** is a **C# console application** that simulates a **mini supermarket management system**.  
The project is built to practice **advanced OOP concepts** (Encapsulation, Inheritance, Polymorphism, Interface, Abstraction) combined with **JSON file-based data storage**.  

---

## ✨ Features  

### 🔐 Authentication & Authorization  
* Register, Login, Forgot Password, Change Password  
* Role-based access:  
  * 👤 **User**: purchase products, view invoices  
  * 🛠️ **Admin**: manage products, orders, staff  

### 📦 Product Management  
* Add / Update / Delete / View products  
* Multiple product types supported:  
  * 🥦 `FoodProduct` (with ExpiryDate)  
  * 💻 `ElectronicProduct` (with WarrantyPeriod)  
  * 👕 `ClothesProduct` (with Size & Color)  

### 👥 Customer Management  
* CRUD operations (Name, Email, Phone, Membership level)  
* Membership system: Normal / VIP  

### 🧑‍💼 Staff Management  
* Two staff roles:  
  * `Cashier` → salary based on hours worked  
  * `Manager` → salary based on base salary + bonus  
* Salary calculation implemented with **Polymorphism**  

### 🧾 Order Management  
* Create orders & auto-update product stock  
* Calculate total price & print invoice to console  

### 📊 Reports  
* Revenue statistics  
* Best-selling products  
* Top-spending customers  

---

## 🛠️ Tech Stack  
* **Language:** C# (.NET 8)  
* **Concepts:** Advanced OOP, SOLID principles  
* **Design:** Abstract classes, Interfaces, Repository Pattern  
* **Data Storage:** JSON file-based storage  
* **Tools:** LINQ for filtering & reporting  

---

## 📸 Demo  

![MarketMini Demo](./docs/demo.png)  
*Main menu of the MarketMini console application*  

---

## 🚀 Getting Started  
Clone the repository and run with .NET CLI:  

```bash
git clone https://github.com/RudeusGs/MarketConsole.git
cd MarketConsole
dotnet run
