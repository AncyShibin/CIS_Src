CREATE TABLE company
(
    company_id INT IDENTITY CONSTRAINT company_pk PRIMARY KEY NONCLUSTERED,
    company_name_english	varchar(200)	NULL,
    company_name_arabic	varchar(200)	NULL,
	company_address_english	varchar(200)	NULL,
    company_address_arabic	varchar(200)	NULL,
	company_code	varchar(200)	NULL,
    tex_id	varchar(200)	NULL,
	currency	varchar(200)	NULL,
	language	varchar(200)	NULL,
	licence_start_date	datetime2(7)	NULL,
	licence_end_date	datetime2(7)	NULL,
	hospital_id	varchar(200)	NULL,
	bank_account_number	varchar(200)	NULL,
	tax_setup	varchar(200)	NULL,
    is_active     BIT DEFAULT 1 NULL,
    modified_on   DATETIME2     NULL
)
GO