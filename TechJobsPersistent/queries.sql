--Part 1
SELECT   TABLE_NAME
       , COLUMN_NAME
       , DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS where (table_name = "jobs")

--Part 2
select column_name from employers where (column_name = "St. Louis")
--Part 3
SELECT name, description FROM skills
LEFT JOIN jobskills ON skills.Id = jobskills.SkillId
WHERE jobskills.JobId is not null

UNION

SELECT name FROM jobs
LEFT JOIN jobskills ON jobs.Id = jobskills.JobId
WHERE jobskills.JobId is not null
ORDER BY name asc;