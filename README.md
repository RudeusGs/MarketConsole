# 🛒 MarketConsole  

**MarketConsole** is a **C# console application** that simulates a **mini supermarket management system**.  
The project is built to practice **advanced OOP concepts** (Encapsulation, Inheritance, Polymorphism, Interface, Abstraction) combined with **file-based data storage**.  

---

## ✨ Features
### 📦 Product Management
- Add / Update / Delete / View products  
- Multiple product types supported:  
  - 🥦 `FoodProduct` (with ExpiryDate)  
  - 💻 `ElectronicProduct` (with WarrantyPeriod)  
  - 👕 `ClothesProduct` (with Size & Color)  

### 👥 Customer Management
- CRUD operations (Name, Phone, Email, Membership level)  

### 🧑‍💼 Staff Management
- Two staff roles:  
  - `Cashier` → salary based on hours worked  
  - `Manager` → salary based on base salary + bonus  
- Salary calculation implemented with **Polymorphism**  

### 🧾 Order Management
- Create orders & auto-update product stock  
- Calculate total price & print invoice to console  

### 📊 Reports
- Revenue statistics  
- Best-selling products  
- Top-spending customers  

---

## 🛠️ Tech Stack
- **Language:** C# (.NET 6 or later)  
- **Concepts:** Advanced OOP, SOLID principles  
- **Design:** Abstract classes, Interfaces, Repository Pattern  
- **Data Storage:** File I/O with `.txt` (extendable to `.json`)  
- **Tools:** LINQ for filtering & reporting  

---

## 🚀 Getting Started
Clone the repository and run with .NET CLI:
```bash
git clone https://github.com/RudeusGs/MarketConsole.git
cd MarketConsole
dotnet run
