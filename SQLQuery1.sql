USE PhumlaKamnandiDB;
GO

-- Fix column name in Guest table to match Booking table
EXEC sp_rename 'Guest.CreditCardLastFourDigits', 'CreditCardLastFour', 'COLUMN';
GO