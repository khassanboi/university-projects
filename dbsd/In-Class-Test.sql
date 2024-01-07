--Task 1
select distinct City
from Person.Address
order by City desc


--Task 2
select *
from Sales.SalesPerson
where Bonus between 2500 and 5000
order by Bonus


--Task 3
select p.Name, t.Quantity, t.TransactionDate, t.ActualCost, p.Color
from [Production].[TransactionHistory] t join Production.Product p on t.ProductID = p.ProductID
where (t.Quantity between 5 and 8) and p.Name like '%sport%'


--Task 4
with ReproducedOrderHistory as (
	select ReferenceOrderID "Order ID", count(*) "Number of Products", sum(ActualCost * Quantity) "Actual Cost"
	from Production.TransactionHistory
	where TransactionDate > '2013-07-31'
	group by ReferenceOrderID
)
select *
from ReproducedOrderHistory r
where "Number of Products" > 60
order by r.[Order ID] desc


--Task 5
with ReproducedSales as (
	select *, avg(SalesLastYear) over() "LastYearAvg"
	from Sales.SalesPerson
)
select s.Name, DATEDIFF(month, p.ModifiedDate, GETDATE()) "Modified * Months Ago", p.LastYearAvg "Last Year Average"
from ReproducedSales p join Sales.Store s on p.BusinessEntityID = s.SalesPersonID
where p.SalesLastYear > 0 and p.SalesLastYear < p.LastYearAvg
order by s.Name desc

select *
from Sales.Store

--Task 6
go
create view products_table as
select "Name", Color, StandardCost
from Production.Product
where Color = 'black'

--Task 7
select e.Gender, e.MaritalStatus "Marital Status", p.FirstName "First Name", p.LastName "Last Name", h.StartDate "Job Start Date", d.GroupName "Department Group Name"
from HumanResources.Employee e 
	left join HumanResources.JobCandidate j on e.BusinessEntityID = j.BusinessEntityID
	join Person.Person p on e.BusinessEntityID = p.BusinessEntityID
	join HumanResources.EmployeeDepartmentHistory h on e.BusinessEntityID = h.BusinessEntityID
	join HumanResources.Department d on h.DepartmentId = d.DepartmentID
where (j.JobCandidateID is null and e.HireDate > '2012-01-01') and DATEPART(month, e.Hiredate) in (5,9)


--Last Year--
----------------------------------------

--Task 1
select JobTitle, HireDate
from HumanResources.Employee

--Task 2
select *
from Production.Product
where StandardCost between 90 and 100
order by StandardCost desc

--Task 3
select pr.[Name], pr.SellStartDate, sc.[Name], pr.ListPrice, pr.Color
from Production.Product pr left join Production.ProductSubcategory sc on pr.ProductSubcategoryID = sc.ProductSubcategoryID 
where pr.[Name] like '%mountain%' and pr.ListPrice between 500 and 800
order by Color desc

--Task 4
select MaritalStatus, Gender, avg(SickLeaveHours), count(*)
from HumanResources.Employee
where BirthDate < '1980-10-10' and SickLeaveHours > 43
group by MaritalStatus, Gender

