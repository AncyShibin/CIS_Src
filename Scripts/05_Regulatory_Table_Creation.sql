CREATE TABLE regulatory
(
    regulatory_id INT IDENTITY CONSTRAINT regulatory_pk PRIMARY KEY NONCLUSTERED,
    regulatory_name	varchar(200)	NULL,
    is_active     BIT DEFAULT 1 NULL,
    modified_on   DATETIME2     NULL
)
GO