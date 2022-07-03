

CREATE TRIGGER SpeakerDateLimitInsert
ON Performance
INSTEAD OF INSERT
AS
BEGIN
DECLARE @Cnt INT;
DECLARE @Theme NVARCHAR(100);
DECLARE @SpeakerId INT;
DECLARE @SectionId INT;
DECLARE @DateTimeStart DATETIME;
DECLARE @Duration TIME;
DECLARE perform_Cursor CURSOR FAST_FORWARD 
FOR 
SELECT Theme, SpeakerId, SectionId, DateTimeStart, Duration FROM inserted	
 OPEN perform_Cursor 
 FETCH NEXT FROM perform_Cursor INTO @Theme, @SpeakerId, @SectionId, @DateTimeStart, @Duration
 WHILE @@FETCH_STATUS = 0 
 BEGIN 
 SELECT @Cnt = COUNT(*) FROM Performance
 WHERE CONVERT(DATE, DateTimeStart) = CONVERT(DATE, @DateTimeStart)
 AND SectionId = @SectionId AND SpeakerId = @SpeakerId
 IF NOT EXISTS(SELECT * FROM Performance WHERE 
 ((@DateTimeStart BETWEEN DateTimeStart AND (DateTimeStart+CAST(Duration AS DATETIME)))
 OR 
 ((@DateTimeStart+CAST(@Duration AS DATETIME)) BETWEEN DateTimeStart AND (DateTimeStart+CAST(Duration AS DATETIME))))
 AND SectionId=@SectionId) AND @Cnt=0
 BEGIN
	INSERT INTO Performance
	(Theme, SpeakerId, SectionId, DateTimeStart, Duration)
	VALUES
	(@Theme, @SpeakerId, @SectionId, @DateTimeStart, @Duration)
 END
 ELSE
 PRINT N'Помилка!!! Перевірте вхідні дані!'
 FETCH NEXT FROM perform_Cursor INTO @Theme, @SpeakerId, @SectionId, @DateTimeStart, @Duration
 END
CLOSE perform_Cursor
DEALLOCATE perform_Cursor
END



CREATE TRIGGER SpeakerDateLimitUpdate
ON Performance
INSTEAD OF UPDATE
AS
BEGIN
DECLARE @Cnt INT;
DECLARE @PerformanceId INT;
DECLARE @Theme NVARCHAR(100);
DECLARE @SpeakerId INT;
DECLARE @SectionId INT;
DECLARE @DateTimeStart DATETIME;
DECLARE @Duration TIME;
DECLARE perform_Cursor CURSOR FAST_FORWARD 
FOR 
SELECT PerformanceId, Theme, SpeakerId, SectionId, DateTimeStart, Duration FROM inserted	
 OPEN perform_Cursor 
 FETCH NEXT FROM perform_Cursor INTO @PerformanceId, @Theme, @SpeakerId, @SectionId, @DateTimeStart, @Duration
 WHILE @@FETCH_STATUS = 0 
 BEGIN 
 SELECT @Cnt = COUNT(*) FROM Performance
 WHERE CONVERT(DATE, DateTimeStart) = CONVERT(DATE, @DateTimeStart)
 AND SectionId = @SectionId AND SpeakerId = @SpeakerId
 IF NOT EXISTS(SELECT * FROM Performance WHERE 
 ((@DateTimeStart BETWEEN DateTimeStart AND (DateTimeStart+CAST(Duration AS DATETIME)))
 OR 
 ((@DateTimeStart+CAST(@Duration AS DATETIME)) BETWEEN DateTimeStart AND (DateTimeStart+CAST(Duration AS DATETIME))))
 AND SectionId=@SectionId) AND @Cnt=0
 BEGIN
	UPDATE Performance
	SET Theme = @Theme, SpeakerId = @SpeakerId, SectionId = @SectionId,
	DateTimeStart = @DateTimeStart, Duration = @Duration
	WHERE PerformanceId = @PerformanceId
 END
 ELSE
 PRINT N'Помилка!!! Перевірте дані, що оновлюються!'
 FETCH NEXT FROM perform_Cursor INTO @PerformanceId, @Theme, @SpeakerId, @SectionId, @DateTimeStart, @Duration
 END
CLOSE perform_Cursor
DEALLOCATE perform_Cursor
END
