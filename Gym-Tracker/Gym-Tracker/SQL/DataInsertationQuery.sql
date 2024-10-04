USE GymTrackerDB
GO

-- These are the inserts for my sample users and gym locations
INSERT INTO [ext_gym_org] (gym_name, gym_city, open_time, close_time) 

VALUES
('FitFusion', 'Miami', CAST('7:00' AS TIME),  CAST('21:00' AS TIME)),
('IronCoreFitness', 'Dallas',  CAST('7:00' AS TIME),  CAST('15:00' AS TIME)),
('MuscleForge', 'Nevada',  CAST('8:00' AS TIME),  CAST('17:00' AS TIME)),
('ReviveFitness', 'PortLand',  CAST('5:00' AS TIME),  CAST('19:00' AS TIME));
GO

-- Insert data into Membership table
INSERT INTO Membership (ID,MembershipLevel,MembershipMonthPrice,MembershipMonthLength)

VALUES
('1','Bronze','2.99','12'),
('2','Gold','9.99','12'),
('3','Gold','9.99','8'),
('4','Silver','7.99','9'),
('5','Bronze','2.99','10'),
('6','Silver','7.99','10'),
('7','Gold','9.99','18'),
('8','Bronze','2.99','12'),
('9','Gold','9.99','8'),
('10','Silver','7.99','6'),
('11','Gold','9.99','6'),
('12','Silver','7.99','10');


GO