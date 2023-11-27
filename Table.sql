CREATE TABLE Account(
	AccountID int identity(1,1) PRIMARY KEY,
	Email nvarchar(150),
	[Password] nvarchar(150)
)

CREATE TABLE Wallet(
	WalletID int identity(1,1) PRIMARY KEY,
	AccountID int FOREIGN KEY REFERENCES Account(AccountID),
	WalletName nvarchar(150),
	Balance money
)

CREATE TABLE Category(
	CategoryID int identity(1,1) PRIMARY KEY,
	CategoryName nvarchar(150)
)

CREATE TABLE SubCategory(
	SCID int identity(1,1) PRIMARY KEY,
	SCName nvarchar(150),
	CategoryID int FOREIGN KEY REFERENCES Category(CategoryID)
)

CREATE TABLE Budget(
	BudgetID int identity(1,1) PRIMARY KEY,
	AccountID int FOREIGN KEY REFERENCES Account(AccountID),
	CategoryID int FOREIGN KEY REFERENCES Category(CategoryID),
	SCID int FOREIGN KEY REFERENCES SubCategory(SCID),
	WalletID int FOREIGN KEY REFERENCES Wallet(WalletID),
	[From] date,
	[To] date,
	Amount money,
	Note nvarchar(MAX),
	BudgetName nvarchar(150)
)

CREATE TABLE [Transaction](
	TransactionID int identity(1,1) PRIMARY KEY,
	AccountID int FOREIGN KEY REFERENCES Account(AccountID),
	WalletID int FOREIGN KEY REFERENCES Wallet(WalletID),
	CategoryID int FOREIGN KEY REFERENCES Category(CategoryID),
	SCID int FOREIGN KEY REFERENCES SubCategory(SCID),
	BudgetID int FOREIGN KEY REFERENCES Budget(BudgetID),
	Opening money,
	Ending money,
	Balance money,
	TransDate datetime,
	Note nvarchar(MAX)
)