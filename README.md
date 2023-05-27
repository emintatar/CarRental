# CAR RENTAL SYSTEM

## STAGE 1

- Create a brand new project. Its name will be CarRental.

- Create Entities, DataAccess, Business and Console layers.

- Create a "Car" object.

- As property: Add Id, BrandId, ColorId, ModelYear, DailyPrice, Description fields.

- Write the GetById, GetAll, Add, Update, Delete operations in InMemory format.

- Test it in console.

## STAGE 2

- Add Brand and Color objects (Entity)
  Brand-->Id,Name
  Color-->Id,Name

- Set up a new database on the SQL Server side. Create the Cars, Brands, Colors tables. (Research)

- Write the Generic IEntityRepository infrastructure to the system.

- Write Entity Framework infrastructure for Car, Brand and Color objects.

- Write GetCarsByBrandId , GetCarsByColorId services.

- Run the rules below when a new car is added to the system.

  - Car name must be a minimum of 2 characters

  - The car daily price must be greater than 0.

## STAGE 3

- Create a Core layer in your CarRental Project.

- Create and add your IEntity, IDto, IEntityRepository, EfEntityRepositoryBase files as in the 9th day lesson.

- Prepare all CRUD operations for your Car, Brand, Color classes.

- Test all your CRUD operations for Car, Brand, Model objects in Console. GetAll, GetById, Insert, Update, Delete.

- List the cars with the following information. CarName, BrandName, ColorName, DailyPrice. (Hint: Create IDto and write join to 3 tables)

## STAGE 4

- Configure Results in the Core layer.

- Refactor (improve the code) all the Business classes you have developed before, according to this structure.

- Create the users table. Users-->Id,FirstName,LastName,Email,Password

- Create the customers table. Customers-->UserId,CompanyName

- Users and customers are related.

- Create a table holding the rental information of the car. Rentals-->Id, CarId, CustomerId, RentDate(HireDate), ReturnDate(Delivery Date). ReturnDate is null if the car is not delivered.

- Create these entities in your project.

- Write the CRUD operations.

- Add new customers.

- Code the possibility of renting the car. Rental-->Add

- In order for the car to be rented, the car must be delivered.

## STAGE 5

- Create the WebAPI layer.

- Write the Api equivalent of all services in the Business layer.

- Test in Postman.

## STAGE 6

- Add Autofac support to your project.

- Add FluentValidation support to your project.

- Add AOP support support to your project.
