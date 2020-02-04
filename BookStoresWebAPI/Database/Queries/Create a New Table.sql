CREATE TABLE [dbo].[User2] (
    [user_id]       INT           IDENTITY (1, 1) NOT NULL,
    [email_address] VARCHAR (100) NOT NULL,
    [password]      VARCHAR (100) NOT NULL,
    [source]		VARCHAR (100) NOT NULL,
    [first_name]    VARCHAR (20)  NULL,
    [middle_name]   CHAR (1)      NULL,
    [last_name]     VARCHAR (30)  NULL,
    [job_id]        SMALLINT      DEFAULT ((1)) NOT NULL,
    [job_level]     TINYINT       DEFAULT ((10)) NULL,
    [pub_id]        INT           DEFAULT ((1)) NOT NULL,
    [hire_date]     DATETIME      DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_user_id_2] PRIMARY KEY NONCLUSTERED ([user_id] ASC),
    FOREIGN KEY ([job_id]) REFERENCES [dbo].[Job] ([job_id]) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY ([pub_id]) REFERENCES [dbo].[Publisher] ([pub_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

