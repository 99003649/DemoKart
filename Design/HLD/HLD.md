**Product title: - Ecommerce Website**

**Product purpose: -**

Online Shopping is e-commerce web application, which retails various fashion and lifestyle products. This project allows viewing various products available enables registered users to purchase desired products instantly using payment processors and can place orders by using Cash on Delivery (Pay Later) option. This project provides easy access to Administrators to view orders placed using Pay Later and Instant Pay options.

**Project goals &amp; Objectives: -**

- The objective of this project is to develop a general-purpose e-commerce store where products like clothes can be bought from the comfort of home through the Internet.
- An online store is a virtual store on the Internet where customers can browse the catalog and select products of interest.
- The selected items may be collected in a shopping cart.
- At checkout time, the items in the shopping cart will be presented as an order.
- At that time, more information will be needed to complete the transaction.
- Usually, the customer will be asked to fill or select a billing address, a shipping address, a shipping option, and payment information such as credit card number.

![](RackMultipart20210224-4-1f44po2_html_260e102cd646cf9e.png)

**Scope: -**

- Any member can register and view available products.
- Only registered members can purchase multiple products regardless of quantity.
- There are two roles available: User and Admin.
- Users can view and purchase products.
- An Admin has some extra privileges including all privileges of the user.
- Admin can add products, edit product information and add/remove product.
- Admin can add users, edit user information and can remove users.
- Admin can ship orders to users based on order placed by sending confirmation mail.

**Structural: -**

**Classes: -**
- User class have all the login funtion in it.
- Category class having all the product categories like Electronics, Clothing, Grocery etc.
- Product class having all the item list with their price, id, name, quantity etc.
- Cart class will show the added products in cart by user.
- order class will take user data like phone no., address, email, name etc.
- Payment class have payment mode by which user can pay like cash on delivery, Credit card etc. 

**Attributes & Function: -**
- UserId
- Pass
- CheckLogin
- ProductId
- ProductName
- ProductPrice
- ProductQuantity
- CatId
- CatName
- AddToCart
- Name
- Address
- PhoneNo
- GetInfo
