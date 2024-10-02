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

