DECLARE @i INT = 1;

WHILE @i <= 150
BEGIN
    INSERT INTO Room (RoomNum, MaxOccupancy, Availability)
    VALUES (@i, 4, 1);

    SET @i = @i + 1;
END
