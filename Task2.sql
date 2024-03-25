SELECT 
p.name as ProductName, 
c.name as CategoryName
FROM Product p
LEFT JOIN ProductCategory pc on p.id = pc.ProductId
LEFT JOIN Category c on pc.CategoryId = c.id
