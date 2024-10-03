CREATE TABLEc (
	[id] int PRIMARY KEY IDENTITY(1, 1),
	[gym_name] nvarchar(255) UNIQUE NOT NULL,
	[gym_city] nvarchar(255) NOT NULL,
	[open_time] time,
	[close_time] time
	)
	GO

CREATE TABLE [ext_user_data] (
	[id] int PRIMARY KEY IDENTITY(1, 1),
	[user_name] nvarchar(255) NOT NULL,
	[user_password] int NOT NULL,
	[user_email] nvarchar(255) NOT NULL,
	[user_address] nvarchar(255) NOT NULL,
	[user_city] nvarchar(255) NOT NULL,
	[user_joined] date,
	[user_level] nvarchar(255) NOT NULL
	)
	GO

CREATE TABLE Membership (
MembershipLevel Varchar(8) NOT NULL,
MembershipPrice int NOT NULL,
ID int,
FOREIGN KEY ([id]) REFERENCES  [ext_gym_org]([id])
);
GO
