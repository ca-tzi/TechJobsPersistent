--Part 1
SELECT   TABLE_NAME
       , COLUMN_NAME
       , DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS where (table_name = "jobs")

--Part 2
select column_name from employers where (column_name = "St. Louis")
--Part 3

