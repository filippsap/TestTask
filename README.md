## Вопрос №1

Разместите код на Github и приложите ссылку. Если в задании что-то непонятно, опишите возникшие вопросы и сделанные предположения. Например, в комментариях в коде.

Задание:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 

Дополнительно к работоспособности оценим:
* Юнит-тесты
* Легкость добавления других фигур
* Вычисление площади фигуры без знания типа фигуры в compile-time
* Проверку на то, является ли треугольник прямоугольным
  
## Вопрос №2

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.

Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

По возможности — положите ответ рядом с кодом из первого вопроса.

Ответ на второй вопрос:

```sql
CREATE TABLE Product
(
    Id int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(MAX)
)

CREATE TABLE Category
(
    id int IDENTITY(1,1) PRIMARY KEY,
    name nvarchar(MAX)
)

CREATE TABLE ProductCategory
(
    Id int IDENTITY(1,1) PRIMARY KEY,
    ProductId int,
    CategoryId int,
)

INSERT INTO Category
VALUES
    ('Продукты питания'),
    ('Лекарства')

INSERT INTO Product
VALUES
    (''),
    ('Молоко'),
    ('Масло'),
    ('Таблетки'),
    ('Молоток')

INSERT INTO ProductCategory
VALUES
    (1, 1),
    (2, 1),
    (3, 1),
    (4, 2)


SELECT 
p.Name as ProductName, 
c.Name as CategoryName
FROM Product p
LEFT JOIN ProductCategory pc on p.id = pc.ProductId
LEFT JOIN Category c on pc.CategoryId = c.id
```
