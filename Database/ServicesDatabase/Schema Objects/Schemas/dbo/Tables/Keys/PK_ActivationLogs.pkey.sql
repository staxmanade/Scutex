﻿ALTER TABLE [dbo].[ActivationLogs]
    ADD CONSTRAINT [PK_ActivationLogs] PRIMARY KEY CLUSTERED ([ActivationLogId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
